using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire
{
    public partial class frmGestionnaire : Form
    {

        private Thread threadServeur;
        bool enEcoute = false;
        TcpListener ecouteTCP;

        int taille = 10;
        private byte[] tamponServeurReception;
        private byte[] tamponServeurExpedition;
        private bool donneesRecues = false;


        public frmGestionnaire()
        {
            InitializeComponent();

            tamponServeurReception = new byte[taille];
            tamponServeurExpedition = new byte[taille];
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
            while (enEcoute)
            {
                if (ecouteTCP.Pending())
                {
                    TcpClient clientTcp = ecouteTCP.AcceptTcpClient();
                    NetworkStream stream = clientTcp.GetStream();

                    stream.Read(tamponServeurReception, 0, taille);

                    // tamponServeurExpedition = Encoding.ASCII.GetBytes("Ok!");
                    //for (int i = 0; i < taille; ++i)
                    //    tamponServeurExpedition[i] = (byte)(tamponServeurReception[i] + 1);

                    // stream.Write(tamponServeurExpedition, 0, taille);

                    clientTcp.Close();
                    donneesRecues = true;
                }
                else
                {
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
                string noCarte = Encoding.ASCII.GetString(tamponServeurReception);
                AjouteHistorique(noCarte, lstHistorique);

                string timeInMetric = DateTime.Now.Hour.ToString() + ((int)(DateTime.Now.Minute / 60.0 * 100.0)).ToString();

                switch (GestionnaireBUS.AAccess(noCarte, "1133", timeInMetric))
                {
                    case GestionnaireBUS.AccesTypes.aucun:
                        txtMsg.Text = "Aucun";
                        break;
                    case GestionnaireBUS.AccesTypes.hors_plage:
                        txtMsg.Text = "Hors plage";
                        break;
                    case GestionnaireBUS.AccesTypes.ok:
                        txtMsg.Text = "Accès";
                        break;
                }

                donneesRecues = false;
            }

            tmrMain.Enabled = true;
        }

        private void AjouteHistorique(string chaine, ListBox lst)
        {
            if (lst.Items.Count > 9)
                lst.Items.RemoveAt(0);
            lst.Items.Add(chaine);
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            demarrerEcoute();
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

        }

        private void initPersonnes()
        {
            dgvPersonnes.AutoGenerateColumns = true;
            dgvPersonnes.AutoResizeColumns();

            dgvPersonnes.DataSource = GestionnaireBUS.ObtenirPersonnes();
            dgvPersonnes.Columns["id"].Visible = false;
        }

        private void initPermissions()
        {
            dgvPermissions.AutoGenerateColumns = true;
            dgvPermissions.AutoResizeColumns();

            dgvPermissions.DataSource = GestionnaireBUS.ObtenirPermissions();
            dgvPermissions.Columns["id"].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string timeInMetric = DateTime.Now.Hour.ToString() + ((int)(DateTime.Now.Minute / 60.0 * 100.0)).ToString();

            switch (GestionnaireBUS.AAccess("0003870622", "1133", timeInMetric))
            {
                case GestionnaireBUS.AccesTypes.aucun:
                    txtMsg.Text = "Aucun";
                    break;
                case GestionnaireBUS.AccesTypes.hors_plage:
                    txtMsg.Text = "Hors plage";
                    break;
                case GestionnaireBUS.AccesTypes.ok:
                    txtMsg.Text = "Accès";
                    break;
            }
        }
    }
}
