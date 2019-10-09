using System;
using System.Windows.Forms;
using OpenCvSharp;
using gei1076_tools;

namespace Relais
{
    public partial class frmRelais : Form
    {
        VideoCapture cap = new VideoCapture(0);
        Mat frame = new Mat();

        private const int tailleTrame = 16;
        private byte[] trame = new byte[tailleTrame];
        private byte[] tableau = new byte[tailleTrame];

        PortSerie ps;
        private byte octet;

        public frmRelais()
        {
            InitializeComponent();

            
        }

        private void frmRelais_Load(object sender, EventArgs e)
        {

            if (!cap.Read(frame))
            {
                txtDataRead.Text = "Erreur de capture";
                return;
            }

            pbCamera.Width = frame.Width;
            pbCamera.Height = frame.Height;

            txtDataRead.Text = frame.Width.ToString();


            pbCamera.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);

            tmrCam.Enabled = true;
        }

        private void matToPictureBox(PictureBox pb, Mat img)
        {
            pb.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(img);
        }

        private void tmrCam_Tick(object sender, EventArgs e)
        {
            cap.Read(frame);
            matToPictureBox(pbCamera, frame);
            txtDataRead.Text = frame.Width.ToString();
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
                        
                    }
                }
            }

            tmrSerie.Enabled = true;
        }
    }
}
