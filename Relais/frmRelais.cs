using System;
using System.Windows.Forms;
using OpenCvSharp;
using gei1076_tools;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Linq;
using System.IO;
using System.Drawing.Imaging;
using Gestionnaire;

namespace Relais
{
    public partial class frmRelais : Form
    {
        public enum AccesTypes { aucun, hors_plage, ok };

        // Réseau
        Socket socket;
        IPAddress adresseIP;
        IPEndPoint endPoint;
        byte[] trameReseau;
        int networkBufferSize = 256;
        byte[] reponse;
        bool donneesReseauPretes = false;

        // Image
        VideoCapture cap = new VideoCapture(0);
        Mat frame = new Mat();
        MemoryStream ms = new MemoryStream();

        // Port série
        private const int tailleTrame = 28;
        private byte[] trame = new byte[tailleTrame];
        private byte[] tableau = new byte[tailleTrame];
        PortSerie ps;
        private byte octet;
        bool donneesSeriePretes = false;

        string cardId = "";
        string localNumber = "";

        bool camPresent = true;

        public frmRelais()
        {
            InitializeComponent();

        }

        private void frmRelais_Load(object sender, EventArgs e)
        {
            txtIPView.DataBindings.Add(new Binding("Text", txtIPServeur, "Text"));
            txtLocalView.DataBindings.Add(new Binding("Text", txtLocal, "Text"));

            lblUSB.DataBindings.Add(new Binding("Enabled", rbtnUSB, "Checked"));
            txtUSB.DataBindings.Add(new Binding("Enabled", rbtnUSB, "Checked"));

            initTooltips();
            initReseau();
            initPortSerie();
            initCamera();

        }



        private void matToPictureBox(PictureBox pb, Mat img)
        {
            pb.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(img);
        }

        private void tmrCam_Tick(object sender, EventArgs e)
        {
            

            tmrCam.Enabled = false;

            if (!camPresent)
            {
                frame = Mat.Zeros(320, 240, MatType.CV_8UC3);
            }
            else
            {
                cap.Read(frame);
            }


            matToPictureBox(pbCamera, frame);

            tmrCam.Enabled = true;
            
        }

        private void tmrSerie_Tick(object sender, EventArgs e)
        {
            tmrSerie.Enabled = false;
            
            while (ps.DonneesALire() >= tailleTrame + 2)
            {
                ps.LireOctet(ref octet);
                if (octet == 0x5A)
                {
                    ps.LireOctet(ref octet);
                    if (octet == 0xA5)
                    {   
                        ps.LireOctets(tableau, 0, tailleTrame);
                        donneesSeriePretes = true;
                    }
                }
            }

            tmrSerie.Enabled = true;
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            tmrMain.Enabled = false;

            if (donneesSeriePretes)
            {
                string identifiant = Encoding.ASCII.GetString(tableau);

                if (txtDataRead.Lines.Length > 9)
                {
                    txtDataRead.Lines[txtDataRead.Lines.Length - 1] = null;
                }

                txtDataRead.Text += identifiant + Environment.NewLine;
                //txtDataRead.Text.Insert(0, identifiant + Environment.NewLine);
                txtUSB.Text = identifiant + Environment.NewLine;
                donneesSeriePretes = false;
            }

            if (donneesReseauPretes)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(DateTime.Now.ToString() + " -- ");

                switch (reponse[0])
                {
                    
                    case (int)AccesTypes.aucun:
                        sb.Append("Aucun");
                        break;
                    case (int)AccesTypes.hors_plage:
                        sb.Append("Hors plage");
                        break;
                    case (int)AccesTypes.ok:
                        sb.Append("Ok");
                        break;
                }

                sb.Append(Environment.NewLine);

                txtDemandes.Text = txtDemandes.Text.Insert(0, sb.ToString());

                // Écriture au port série
                ps.EcrireOctet(reponse[0]);

                donneesReseauPretes = false;
            }

            tmrMain.Enabled = true;
        }

        private void initCamera()
        {
            try { 
                if (!cap.Read(frame))
                {
                    txtDataRead.Text = "Erreur de capture";
                    return;
                }

                pbCamera.Width = frame.Width;
                pbCamera.Height = frame.Height;
            
                pbCamera.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);
            } catch (Exception e)
            {
                MessageBox.Show("Il semble y avoir un problème avec la caméra.\r\n" + e.Message, "Erreur");
                camPresent = false;
            }
            
            tmrCam.Enabled = true;
        }

        private void initPortSerie()
        {
            ps = spc.getPS();

            spc.DataBindings.Add(new Binding("Enabled", rbtnSerie, "Checked"));
            tmrSerie.Enabled = true;
        }

        private void initReseau()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            trameReseau = new byte[networkBufferSize];
            reponse = new byte[1];
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtIPServeur.Text != "")
            {
                try
                {
                    adresseIP = IPAddress.Parse(txtIPServeur.Text);

                    trameReseau = Encoding.ASCII.GetBytes("Alive!");

                    endPoint = new IPEndPoint(adresseIP, int.Parse(txtPort.Text));

                    

                } catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Erreur");
                }
            }
        }

        private void envoyer()
        {
            if (endPoint == null) return;

            
            Socket socketEnvoi = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            adresseIP = IPAddress.Parse(txtIPServeur.Text);
            endPoint = new IPEndPoint(adresseIP, int.Parse(txtPort.Text));

            try {
                socketEnvoi.Connect(endPoint);

                //socketEnvoi.Send(message.Data);

                // Envoyer le local et la clé
                socketEnvoi.Send(trameReseau);

                // Attendre la réponse du serveur
                socketEnvoi.Receive(reponse);

                if (camPresent)
                // Envoyer l'image
                    socketEnvoi.Send(ms.ToArray());

                socketEnvoi.Dispose();

                donneesReseauPretes = true;
            } catch (Exception e)
            {
                MessageBox.Show("Il semble y avoir eu une erreur avec la communication.\r\n" + e.Message, "Erreur");
            }
            
            
        }


        bool okToSend = false;
        int txtEventCount = 0;
        MessageOverSocket message;

        private void txtUSB_TextChanged(object sender, EventArgs e)
        {
            if (txtEventCount < 1)
            {
                
                if (txtUSB.Text.Contains("\r"))
                {
                    txtUSB.Text.Replace("\r", "");
                    txtUSB.Text.Replace("\n", "");
                    okToSend = true;
                }

                if (okToSend)
                {
                    txtEventCount++;
                    cardId = cleanCardID(txtUSB.Text);
                    localNumber = txtLocal.Text;

                    txtMsg.Text += cardId + "\r\n";

                    

                    // Creation du paquet
                    trameReseau = Encoding.ASCII.GetBytes(localNumber + "~" + cardId);

                    if (pbCamera.Image != null)
                    {
                        pbCamera.Image.Save(ms, ImageFormat.Bmp);
                        ms.Position = 0;

                        string filename = AppDomain.CurrentDomain.BaseDirectory + DateTime.Now.ToString("yyyyMMdd_hhmmss")  + ".jpg";

                        pbCamera.Image.Save(filename, ImageFormat.Jpeg);

                        pbLastCapture.Image = pbCamera.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(new Mat(filename)) ;

                        txtMsg.Text += "Image sauvegardée : " + filename + "\r\n";
                    }

                    message = MessageSerializer.Serialize(new Snapshot(localNumber, cardId, pbCamera.Image));

                    envoyer();

                    txtUSB.Text = "";
                    okToSend = false;
                    txtEventCount = 0;
                }
            }
        }

        private string cleanCardID(string cardId)
        {
            if (string.IsNullOrEmpty(cardId)) return cardId;

            string cleaned = new string(cardId.Where(char.IsDigit).ToArray());

            return cleaned;
        }

        private void initTooltips()
        {
            tipAcquisition.SetToolTip(grboxAcquisition, "Pour fin de test, le mode USB permet de connecter un module USB au lieu de UART pour la lecture des cartes. Il suffira d'avoir le focus sur le champ \"Test de lecture\"");
            tipTestUSB.SetToolTip(txtUSB, "Entrez le code à tester et appuyer sur Entrée");
        }

    }
}
