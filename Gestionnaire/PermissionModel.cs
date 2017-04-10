using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
    class PermissionModel
    {
        private int _plageDebut;
        private int _plageFin;

        public int Id { get;}
        public string Id_personne { get; set; }
        public string Id_local { get; set; }
        public string Personne { get; set; }

        public string NumeroLocal { get; set; }

        public string PlageDebut
        {
            get
            {
                return _plageDebut.ToString();
            }
            set
            {
                _plageDebut = int.Parse(value);
            }
        }

        public string PlageFin
        {
            get
            {
                return _plageFin.ToString();
            }
            set
            {
                _plageFin = int.Parse(value);
            }
        }

        public bool inRange(DateTime time)
        {
            int currentTime = int.Parse(time.Hour.ToString() + time.Minute.ToString());

            return currentTime >= _plageDebut && currentTime <= _plageFin;
        }

        public bool inRange(string time)
        {

            int currentTime = int.Parse(time);

            return currentTime >= _plageDebut && currentTime <= _plageFin;
        }

    }
}
