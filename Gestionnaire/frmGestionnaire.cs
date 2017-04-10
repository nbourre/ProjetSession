using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Gestionnaire
{
    public partial class frmGestionnaire : Form
    {

        private Thread threadServeur;
        bool enEcoute = false;
        TcpListener ecouteTCP;

        int networkBufferSize = 256;
        int imageBufferSize = 1000000;

        private byte[] tamponServeurReception;
        private byte[] tamponServeurExpedition;
        private byte[] tamponImage;
        private bool donneesRecues = false;

        private List<string> historique;

        GestionnaireBUS.AccesTypes dernierAcces;

        PersonneModel currentPersonne;
        PermissionModel currentPermission;
        LocalModel currentLocal;

        Color invalidColor = Color.FromArgb(255, 128, 128);
        Color defaultColor;

        public frmGestionnaire()
        {
            InitializeComponent();

            defaultColor = txtCodeCarte.BackColor;

            tamponServeurReception = new byte[networkBufferSize];
            tamponServeurExpedition = new byte[1];
            tamponImage = new byte[imageBufferSize];

            historique = new List<string>();

            Binding ipBind = new Binding("SelectedItem", txtIP_view, "Text");

            ipBind.Format += new ConvertEventHandler(ipBind_format);
            ipBind.Parse += new ConvertEventHandler(ipBind_format);

            cboIPs.DataBindings.Add(ipBind);
        }

        private void ipBind_format(object sender, ConvertEventArgs e)
        {
            ComboBox cbo = (ComboBox)((Binding)sender).Control;

            if (cbo.SelectedItem != null)
            {
                e.Value = cbo.SelectedItem.ToString() + ":" + txtPort.Text;
            }
            
        }


        private void demarrerEcoute()
        {
            if (cboIPs.SelectedIndex < 0) return;


            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress adresseLocale = IPAddress.Parse(cboIPs.SelectedItem.ToString());

            if (ecouteTCP != null)
            {
                ecouteTCP.Stop();                
            }

            ecouteTCP = new TcpListener(adresseLocale, int.Parse(txtPort.Text));
            ecouteTCP.Start();

            if (threadServeur == null || !threadServeur.IsAlive)
            {
                threadServeur = new Thread(new ThreadStart(GereEcoute));
                enEcoute = true;
                threadServeur.Start();
            }

        }

        private void GereEcoute()
        {
            int counter = 0;

            while (enEcoute)
            {
                
                if (ecouteTCP.Pending())
                {
                    counter++;
                    TcpClient clientTcp = ecouteTCP.AcceptTcpClient();
                    NetworkStream stream = clientTcp.GetStream();

                    stream.Read(tamponServeurReception, 0, networkBufferSize);

                    // interroger la BD
                    dernierAcces = 
                        interrogerBD(Encoding.ASCII.GetString(tamponServeurReception));

                    //Envoyer la réponse                    
                    tamponServeurExpedition[0] = (byte)dernierAcces;         
                    stream.Write(tamponServeurExpedition, 0, 1);

                    // Attendre l'image
                    stream.Read(tamponImage, 0, imageBufferSize);
                    
                    clientTcp.Close();

                    donneesRecues = true;
                }
                else
                {
                    counter = 0;
                    Thread.Sleep(20);
                }
            }
            ecouteTCP.Stop();
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            tmrMain.Enabled = false;

            if (donneesRecues)
            {
                lstHistorique.Items.Clear();

                foreach (object o in historique)
                {
                    lstHistorique.Items.Add(o);
                }

                if (tamponImage != null)
                {
                    MemoryStream ms = new MemoryStream(tamponImage);

                    pbRelais.Image = Image.FromStream(ms);
                }

                switch(dernierAcces)
                {
                    case GestionnaireBUS.AccesTypes.aucun:
                        txtMsg.Text = "Aucun accès";
                        break;
                    case GestionnaireBUS.AccesTypes.ok:
                        txtMsg.Text = "Ok";
                        break;
                    case GestionnaireBUS.AccesTypes.hors_plage:
                        txtMsg.Text = "Hors plage";
                        break;
                }


                donneesRecues = false;
            }

            tmrMain.Enabled = true;
        }

        private void AjouteHistorique(string chaine, ListBox lst)
        {
            if (historique.Count > 9)
                historique.RemoveAt(0);
            historique.Add(chaine);
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            demarrerEcoute();

            tabMain.SelectedTab = tpgPrincipale;
        }

        private void frmGestionnaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadServeur != null && threadServeur.IsAlive)
                threadServeur.Abort();
        }

        void initIPList()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in ipHostInfo.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    cboIPs.Items.Add(ip.ToString());
                }
            }
        }

        private void frmGestionnaire_Load(object sender, EventArgs e)
        {
            initIPList();
            initDB();

            tabMain.SelectedTab = tabConfig;
        }

        private void initDB()
        {
            initLocaux();
            initPersonnes();
            initPermissions();

        }

        private void initLocaux()
        {
            dgvLocaux.AutoGenerateColumns = true;
            dgvLocaux.AutoResizeColumns();

            dgvLocaux.DataSource = GestionnaireBUS.ObtenirLocaux();
            dgvLocaux.Columns["id"].Visible = false;

            cboLocaux.DataSource = dgvLocaux.DataSource;
            cboLocaux.SelectedIndex = -1;

        }

        private void initPersonnes()
        {
            dgvPersonnes.AutoGenerateColumns = true;
            dgvPersonnes.AutoResizeColumns();

            dgvPersonnes.DataSource = GestionnaireBUS.ObtenirPersonnes();
            dgvPersonnes.Columns["id"].Visible = false;

            cboPersonnes.DataSource = dgvPersonnes.DataSource;
            cboPersonnes.SelectedIndex = -1;
        }

        private void initPermissions()
        {
            dgvPermissions.AutoGenerateColumns = true;
            dgvPermissions.AutoResizeColumns();

            dgvPermissions.DataSource = GestionnaireBUS.ObtenirPermissions();
            dgvPermissions.Columns["id"].Visible = false;
            dgvPermissions.Columns["id_local"].Visible = false;
            dgvPermissions.Columns["id_personne"].Visible = false;



        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string timeInMetric = DateTime.Now.Hour.ToString() + ((int)(DateTime.Now.Minute / 60.0 * 100.0)).ToString();

        //    switch (GestionnaireBUS.AAccess("0003870622", "1133", timeInMetric))
        //    {
        //        case GestionnaireBUS.AccesTypes.aucun:
        //            txtMsg.Text = "Aucun";
        //            break;
        //        case GestionnaireBUS.AccesTypes.hors_plage:
        //            txtMsg.Text = "Hors plage";
        //            break;
        //        case GestionnaireBUS.AccesTypes.ok:
        //            txtMsg.Text = "Accès";
        //            break;
        //    }
        //}

        private GestionnaireBUS.AccesTypes interrogerBD (string donnees)
        {
            GestionnaireBUS.AccesTypes resultat = GestionnaireBUS.AccesTypes.aucun;

            string[] donneesBrutes = donnees.Replace("\0", "").Split('~');

            string local = donneesBrutes[0];
            string noCarte = donneesBrutes[1].Trim();

            AjouteHistorique(local + " <-- " + noCarte, lstHistorique);

            string timeInMetric = DateTime.Now.Hour.ToString() + ((int)(DateTime.Now.Minute / 60.0 * 100.0)).ToString();

            resultat = GestionnaireBUS.AAccess(noCarte, local, timeInMetric);

            return resultat;
        }

        private void dgvPersonnes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;

            currentPersonne = ((List<PersonneModel>)dgvPersonnes.DataSource)[e.RowIndex];

            txtPrenom.Text = currentPersonne.Prenom;
            txtNom.Text = currentPersonne.Nom;
            txtCodeCarte.Text = currentPersonne.CodeCarte;
        }

        private void btnPersonneAjouter_Click(object sender, EventArgs e)
        {
            if (txtCodeCarte.Text == "") {
                txtCodeCarte.BackColor = invalidColor;   
                return;
            }

            txtCodeCarte.BackColor = defaultColor;
            
            if (currentPersonne == null)
            {
                currentPersonne = new PersonneModel();
            }

            currentPersonne.CodeCarte = txtCodeCarte.Text;
            currentPersonne.Prenom = txtPrenom.Text;
            currentPersonne.Nom = txtNom.Text;

            if (GestionnaireBUS.ObtenirPersonneParCarte(currentPersonne.CodeCarte).Count == 0)
            {
                if (!GestionnaireBUS.AjouterPersonne(currentPersonne))
                {
                    MessageBox.Show("Une erreur est survenue. Impossible d'ajouter la personne.", "Erreur");
                    return;
                }

                initPersonnes();
                

            } else
            {
                MessageBox.Show("Ce numéro de carte est déjà utilisé.", "Erreur");
            }
        }

        private void btnPersonneSupprimer_Click(object sender, EventArgs e)
        {
            if (currentPersonne == null)
            {
                MessageBox.Show("Veuillez sélectionner une personne de la liste.", "Erreur");
                return;
            }

            if (!GestionnaireBUS.SupprimerPersonne(currentPersonne.Id))
            {
                MessageBox.Show("Une erreur est survenue lors de la tentative de suppression", "Erreur");
                return;
            }

            initPersonnes();
            initPermissions();
        }

        private void dgvLocaux_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;

            currentLocal = ((List<LocalModel>)dgvLocaux.DataSource)[e.RowIndex];

            txtLocalNumero.Text = currentLocal.Numero;
            txtLocalDescription.Text = currentLocal.Description;
        }

        private void btnLocalAjouter_Click(object sender, EventArgs e)
        {
            if (txtLocalNumero.Text == "")
            {
                txtLocalNumero.BackColor = invalidColor;
                return;
            }

            txtLocalNumero.BackColor = defaultColor;

            if (currentLocal == null)
            {
                currentLocal = new LocalModel();
            }

            currentLocal.Description = txtLocalDescription.Text;
            currentLocal.Numero = txtLocalNumero.Text;

            if (GestionnaireBUS.ObtenirLocauxParNumero(currentLocal.Numero).Count == 0 )
            {
                if (!GestionnaireBUS.AjouterLocal(currentLocal))
                {
                    
                    MessageBox.Show("Une erreur est survenue. Impossible d'ajouter la personne.", "Erreur");
                    return;
                    
                }

                initLocaux();

            } else
            {
                MessageBox.Show("Ce numéro de local est déjà attribué.", "Erreur");
            }
        }

        private void btnLocalSupprimer_Click(object sender, EventArgs e)
        {
            if (currentLocal == null)
            {
                MessageBox.Show("Veuillez sélectionner un local de la liste.", "Erreur");
                return;
            }

            if (!GestionnaireBUS.SupprimerLocal(currentLocal.Id))
            {
                MessageBox.Show("Une erreur est survenue lors de la tentative de suppression", "Erreur");
                return;
            }

            initLocaux();
            initPermissions();
        }

        private void btnPermissionAjouter_Click(object sender, EventArgs e)
        {
            if (cboPersonnes.SelectedValue == null)
            {
                cboPersonnes.BackColor = invalidColor;
                return;
            }

            if (cboLocaux.SelectedValue == null)
            {
                cboLocaux.BackColor = invalidColor;
                return;
            }

            if (txtPlageDebut.Text == "")
            {
                txtPlageDebut.BackColor = invalidColor;
                return;
            }

            if (txtPlageFin.Text == "")
            {
                txtPlageFin.BackColor = invalidColor;
                return;
            }

            txtPlageFin.BackColor = txtPlageDebut.BackColor = 
                cboPersonnes.BackColor = cboLocaux.BackColor = defaultColor;

            if (currentPermission == null)
            {
                currentPermission = new PermissionModel();
            }

            currentPermission.Id_local = ((LocalModel)cboLocaux.SelectedItem).Id;
            currentPermission.Id_personne = ((PersonneModel)cboPersonnes.SelectedItem).Id;
            currentPermission.PlageDebut = int.Parse(txtPlageDebut.Text).ToString();
            currentPermission.PlageFin = int.Parse(txtPlageFin.Text).ToString();

            if (!GestionnaireBUS.AjouterPermission (currentPermission))
            {
                MessageBox.Show("Il semble y avoir eu un problème lors de la création de l'enregistrement.");
                return;
            }

            initPermissions();
        }

        private void dgvPermissions_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;

            currentPermission = ((List<PermissionModel>)dgvPermissions.DataSource)[e.RowIndex];
            
            txtPlageDebut.Text = currentPermission.PlageDebut;
            txtPlageFin.Text = currentPermission.PlageFin;


            bool found = false;

            for (int i = 0; (i < cboLocaux.Items.Count) && !found; i++)
            {
                if (((LocalModel) cboLocaux.Items[i]).Id == currentPermission.Id_local)
                {
                    cboLocaux.SelectedIndex = i;
                    found = true;
                }
            }

            found = false;
            for (int i = 0; (i < cboPersonnes.Items.Count) && !found; i++)
            {
                if (((PersonneModel)cboPersonnes.Items[i]).Id == currentPermission.Id_personne)
                {
                    cboPersonnes.SelectedIndex = i;
                    found = true;
                }
            }
        }

        private void btnPermissionSupprimer_Click(object sender, EventArgs e)
        {
            if (currentPermission == null)
            {
                MessageBox.Show("Veuillez sélectionner une permission de la liste.", "Erreur");
                return;
            }

            if (!GestionnaireBUS.SupprimerPermission(currentPermission.Id))
            {
                MessageBox.Show("Une erreur est survenue lors de la tentative de suppression", "Erreur");
                return;
            }

            initPermissions();
        }

        private void dgvPermissions_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
