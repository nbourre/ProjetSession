using System;
using System.Drawing;

namespace Relais
{
    [Serializable]
    public class Snapshot
    {
        public string Local { get; set; }
        public string CarteID { get; set; }

        public Image Capture { get; set; }

        public Snapshot(string local, string carteID, Image photo)
        {
            Local = local;
            CarteID = carteID;
            Capture = photo;
        }
    }
}
