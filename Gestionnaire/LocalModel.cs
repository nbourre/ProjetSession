using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
    class LocalModel
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Numero + " : " + Description;
        }
    }
}
