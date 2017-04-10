using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
    class PersonneModel
    {
        public int Id { get; set; }
        public string CodeCarte { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }



        public PersonneModel()
        {

        }

        public PersonneModel(int id, string codeCarte, string nom, string prenom)
        {
            Id = id;
            CodeCarte = codeCarte;
            Nom = nom;
            Prenom = prenom;
        }

        public override string ToString()
        {
            return Nom + ", " + Prenom;
        }
    }
}
