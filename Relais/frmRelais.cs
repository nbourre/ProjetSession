using System;
using System.Windows.Forms;
using OpenCvSharp;
using gei1076_tools;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Linq;

namespace Relais
{
    public partial class frmRelais : Form
    {
        // Réseau
        Socket socket;
        IPAddress adresseIP;
        IPEndPoint endPoint;
        byte[] trameReseau;
        int tailleReseau = 10;

        // Image
        VideoCapture cap = new VideoCapture(0);
        Mat frame = new Mat();

        // Port série
        private const int tailleTrame = 28;
        private byte[] trame = new byte[tailleTrame];
        private byte[] tableau = new byte[tailleTrame];
        PortSerie ps;
        private byte octet;
        bool donneesPretes = false;

        public frmRelais()
        {
            InitializeComponent();

            // Laisser là pour éviter le bogue du designer
            //this.tabConfig.Controls.Add(this.spc);

        }

        private void frmRelais_Load(object sender, EventArgs e)
        {
            txtIPView.DataBindings.Add(new Binding("Text", txtIPServeur, "Text"));
            txtLocalView.DataBindings.Add(new Binding("Text", txtLocal, "Text"));

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
            cap.Read(frame);


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
                        donneesPretes = true;
                    }
                }
            }

            tmrSerie.Enabled = true;
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            tmrMain.Enabled = false;

            if (donneesPretes)
            {
                string identifiant = Encoding.ASCII.GetString(tableau);

                txtDataRead.AppendText (identifiant);
                txtDataRead.AppendText (Environment.NewLine);
         
                donneesPretes = false;
                
            }

            tmrMain.Enabled = true;
        }

        private void initCamera()
        {
            if (!cap.Read(frame))
            {
                txtDataRead.Text = "Erreur de capture";
                return;
            }

            pbCamera.Width = frame.Width;
            pbCamera.Height = frame.Height;

            pbCamera.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);
            
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
            trameReseau = new byte[tailleReseau];
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
                    MessageBox.Show("Erreur", ex.Message);
                }
            }
        }

        private void envoyer()
        {
            if (endPoint == null) return;

            int valeurInitiale = 0;
            Socket socketEnvoi = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            adresseIP = IPAddress.Parse(txtIPServeur.Text);
            endPoint = new IPEndPoint(adresseIP, int.Parse(txtPort.Text));

            try
            {
                valeurInitiale = int.Parse(txtPort.Text);
            }
            catch
            {
                MessageBox.Show("la valeur doit etre un entier", "ERREUR");
                return;
            }

            //for (int i = 0; i < tailleReseau; ++i)
            //    trameReseau[i] = (byte)(valeurInitiale + i);

            socketEnvoi.Connect(endPoint);

            socketEnvoi.Send(trameReseau);

            socketEnvoi.Dispose();
            
        }


        bool okToSend = false;

        private void txtUSB_TextChanged(object sender, EventArgs e)
        {
            if (txtUSB.Text.Contains("\r"))
            {
                okToSend = true;
            }

            string cardId = cleanCardID(txtUSB.Text);


            if (okToSend)
            {
                txtUSB.Text = "";

                txtMsg.Text += cardId + "\r\n";

                trameReseau = Encoding.ASCII.GetBytes(cleanCardID(cardId));
                envoyer();
                okToSend = false;
            }
        }

        private string cleanCardID(string cardId)
        {
            if (string.IsNullOrEmpty(cardId)) return cardId;

            string cleaned = new string(cardId.Where(char.IsDigit).ToArray());

            return cleaned;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
