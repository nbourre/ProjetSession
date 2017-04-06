using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
