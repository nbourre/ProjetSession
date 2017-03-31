using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
    class GestionnaireBUS
    {
        public enum AccesTypes { aucun, hors_plage, ok };

        private static GestionnaireDAO gestionnaireDAO = new GestionnaireDAO();

        public static List­<LocalModel> ObtenirLocauxParNumero(string numero)
        {
            List<LocalModel> locaux = new List<LocalModel>();

            DataTable dt = new DataTable();

            dt = gestionnaireDAO.rechercheLocauxParNumero(numero);

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    LocalModel local = new LocalModel();

                    local.Id = Int32.Parse(row["id"].ToString());
                    local.Numero = row["numero"].ToString();
                    local.Description = row["description"].ToString();

                    locaux.Add(local);
                }
            }

            return locaux;
        }

        public static List­<LocalModel> ObtenirLocaux()
        {
            List<LocalModel> locaux = new List<LocalModel>();

            DataTable dt = new DataTable();

            dt = gestionnaireDAO.rechercheLocauxTous();

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    LocalModel local = new LocalModel();

                    local.Id = Int32.Parse(row["id"].ToString());
                    local.Numero = row["numero"].ToString();
                    local.Description = row["description"].ToString();

                    locaux.Add(local);
                }
            }

            return locaux;
        }

        public static List­<PersonneModel> ObtenirPersonnes()
        {
            List<PersonneModel> personnes = new List<PersonneModel>();

            DataTable dt = new DataTable();

            dt = gestionnaireDAO.recherchePersonnesTous();

            if (dt != null)
            {
                personnes = dt.DataTableToList<PersonneModel>();
            }

            return personnes;
        }

        public static List<PermissionModel> ObtenirPermissions()
        {
            List<PermissionModel> permissions = new List<PermissionModel>();

            DataTable dt = new DataTable();

            dt = gestionnaireDAO.recherchePermissionsTous();

            if (dt != null)
            {
                permissions = dt.DataTableToList<PermissionModel>();
            }

            return permissions;
        }

        public static AccesTypes AAccess (string carteID, string localNumero, string heure)
        {
            AccesTypes resultat = AccesTypes.aucun;

            List<PermissionModel> permissions = new List<PermissionModel>();

            DataTable dt = new DataTable();

            dt = gestionnaireDAO.recherchePermissionsCarteLocal(carteID, localNumero);

            if (dt != null)
            {
                permissions = dt.DataTableToList<PermissionModel>();

                PermissionModel permFiltre = permissions.Find((PermissionModel p) => { return p.inRange(heure); });


                if (permFiltre != null)
                {
                    resultat = AccesTypes.ok;
                } else
                {
                    resultat = permissions.Count > 0 ? AccesTypes.hors_plage : AccesTypes.aucun;
                }

            }

            return resultat;
        }
    }
}
