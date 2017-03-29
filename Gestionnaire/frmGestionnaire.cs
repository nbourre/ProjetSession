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
            int nbOctets = 0;

            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress adresseLocale = null;

            bool trouve = false;

            for (int i = 0; !trouve && (i < ipHostInfo.AddressList.Length); ++i)
            {
                if (ipHostInfo.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    adresseLocale = ipHostInfo.AddressList[i];
                    trouve = true;
                }
            }
            if (!trouve) return;

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


                    for (int i = 0; i < taille; ++i)
                        tamponServeurExpedition[i] = (byte)(tamponServeurReception[i] + 1);

                    stream.Write(tamponServeurExpedition, 0, taille);

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

        private void Minuterie_Tick(object sender, EventArgs e)
        {
            if (donneesRecues)
            {
                AjouteHistorique("Reception Serveur " + tamponServeurReception[0].ToString(), lstHistorique);
                donneesRecues = false;
            }
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
            threadServeur.Abort();
        }
    }
}
