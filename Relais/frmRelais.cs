﻿using System;
using System.Windows.Forms;
using OpenCvSharp;
using gei1076_tools;
using System.Net;
using System.Net.Sockets;
using System.Text;

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



        }

        private void frmRelais_Load(object sender, EventArgs e)
        {
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

            trameReseau = Encoding.ASCII.GetBytes("Alive!");
            //for (int i = 0; i < tailleReseau; ++i)
            //    trameReseau[i] = (byte)(valeurInitiale + i);

            socketEnvoi.Connect(endPoint);

            socketEnvoi.Send(trameReseau);

            socketEnvoi.Receive(trameReseau);

            socketEnvoi.Dispose();

            //AjouteHistorique("Reception Client " + tamponClient[0].ToString(), lstHistorique);
        }


        private void btnTestConnexion_Click(object sender, EventArgs e)
        {
            envoyer();
        }
    }
}