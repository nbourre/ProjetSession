using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Gestionnaire
{
    class GestionnaireDAO
    {
        private connexionOleDb conn;

        public GestionnaireDAO()
        {
            conn = new connexionOleDb();
        }

        /// <summary>
        /// Recherche les enregistrements par nom ou prénom
        /// </summary>
        /// <param name="_numero">Terme de la recherche</param>
        /// <returns>Table de résultats</returns>
        public DataTable rechercheLocauxParNumero(string _numero)
        {
            string query = string.Format(
               "SELECT * " +
               "FROM [Locaux] " +
               "WHERE numero LIKE @numero");
            OleDbParameter[] sqlParameters = new OleDbParameter[1];
            sqlParameters[0] = new OleDbParameter("@numero", OleDbType.WChar);
            sqlParameters[0].Value = Convert.ToString(_numero);

            return conn.executeSelectQuery(query, sqlParameters);
        }

        /// <summary>
        /// Recherche les enregistrements par nom ou prénom
        /// </summary>
        /// <param name="_numero">Terme de la recherche</param>
        /// <returns>Table de résultats</returns>
        public DataTable rechercheLocauxTous()
        {
            string query = string.Format(
               "SELECT * " +
               "FROM [Locaux] ");

            return conn.executeSelectQuery(query, null);
        }

        /// <summary>
        /// Recherche les enregistrements par numéro de carte
        /// </summary>
        /// <param name="_numero">Terme de la recherche</param>
        /// <returns>Table de résultats</returns>
        public DataTable recherchePersonnesParCarte(string _numero)
        {
            string query = string.Format(
               "SELECT * " +
               "FROM [Personnes] " +
               "WHERE codeCarte LIKE @numero");
            OleDbParameter[] sqlParameters = new OleDbParameter[1];
            sqlParameters[0] = new OleDbParameter("@numero", OleDbType.WChar);
            sqlParameters[0].Value = Convert.ToString(_numero);

            return conn.executeSelectQuery(query, sqlParameters);
        }

        /// <summary>
        /// Recherche les permissions par numéro de carte et numero de local
        /// </summary>
        /// <param name="codeCarte">Code la carte</param>
        /// <param name="numeroLocal">Numero du local</param>
        /// <returns>Table de résultats</returns>
        public DataTable recherchePermissionsCarteLocal(string codeCarte, string numeroLocal)
        {
            string query = string.Format(
               "SELECT prs.codeCarte, prs.nom, prs.prenom, perm.plageDebut, perm.plageFin, loc.numero, loc.description " +
               "FROM ((Permissions as perm " +
               "INNER JOIN Personnes as prs ON prs.id = perm.id_personne) " +
               "INNER JOIN Locaux as loc ON loc.id = perm.id_local) " +
               "WHERE (prs.codeCarte LIKE @codeCarte) " +
               "AND (loc.numero LIKE @numero) ");

            OleDbParameter[] sqlParameters = new OleDbParameter[2];

            sqlParameters[0] = new OleDbParameter("@codeCarte", OleDbType.WChar);
            sqlParameters[0].Value = Convert.ToString(codeCarte);

            sqlParameters[1] = new OleDbParameter("@numero", OleDbType.WChar);
            sqlParameters[1].Value = Convert.ToString(numeroLocal);

            return conn.executeSelectQuery(query, sqlParameters);
        }

        /// <summary>
        /// Recherche les enregistrements de la table Personnes
        /// </summary>
        /// <returns>Table de résultats</returns>
        public DataTable recherchePersonnesTous()
        {
            string query = string.Format(
               "SELECT * " +
               "FROM [Personnes] ");

            return conn.executeSelectQuery(query, null);
        }

        public DataTable recherchePermissionsCompletes()
        {
            string query = string.Format(
               "SELECT perm.id_personne, perm.id_local, prs.codeCarte, prs.nom & \", \" & prs.prenom as personne, perm.plageDebut, perm.plageFin, loc.numero as numeroLocal, loc.description " +
               "FROM ((Permissions as perm " +
               "INNER JOIN Personnes as prs ON prs.id = perm.id_personne) " +
               "INNER JOIN Locaux as loc ON loc.id = perm.id_local) "
               );



            return conn.executeSelectQuery(query, null);
        }

        /// <summary>
        /// Recherche les enregistrements de la table Permissions
        /// </summary>
        /// <returns>Table de résultats</returns>
        public DataTable recherchePermissionsTous()
        {
            string query = string.Format(
               "SELECT * " +
               "FROM [Permissions]");

            return conn.executeSelectQuery(query, null);
        }

        public bool ajouterPersonne (string prenom, string nom, string codeCarte)
        {
            string query = string.Format(
                "INSERT INTO Personnes (prenom, nom, codeCarte) " +
                "VALUES (@prenom, @nom, @codeCarte)"
                );

            OleDbParameter[] sqlParameters = new OleDbParameter[3];

            sqlParameters[0] = new OleDbParameter("@prenom", OleDbType.WChar);
            sqlParameters[0].Value = Convert.ToString(prenom);

            sqlParameters[1] = new OleDbParameter("@nom", OleDbType.WChar);
            sqlParameters[1].Value = Convert.ToString(nom);

            sqlParameters[2] = new OleDbParameter("@codeCarte", OleDbType.WChar);
            sqlParameters[2].Value = Convert.ToString(codeCarte);

            return conn.executeInsertQuery(query, sqlParameters);
        }

        internal bool supprimerLocal(int id)
        {
            string query = string.Format(
                "DELETE FROM Locaux " +
                "WHERE id = @id"
                );

            OleDbParameter[] sqlParameters = new OleDbParameter[1];

            sqlParameters[0] = new OleDbParameter("@id", OleDbType.Integer);
            sqlParameters[0].Value = Convert.ToString(id);

            return conn.executeDeleteQuery(query, sqlParameters);
        }

        internal bool ajouterLocal(string numero, string description)
        {
            string query = string.Format(
                "INSERT INTO Locaux (numero, description) " +
                "VALUES (@numero, @description)"
                );

            OleDbParameter[] sqlParameters = new OleDbParameter[2];

            sqlParameters[0] = new OleDbParameter("@numero", OleDbType.WChar);
            sqlParameters[0].Value = Convert.ToString(numero);

            sqlParameters[1] = new OleDbParameter("@description", OleDbType.WChar);
            sqlParameters[1].Value = Convert.ToString(description);
            
            return conn.executeInsertQuery(query, sqlParameters);
        }

        public bool supprimerPersonne(int id)
        {
            string query = string.Format(
                "DELETE FROM Personnes " +
                "WHERE id = @id"
                );

            OleDbParameter[] sqlParameters = new OleDbParameter[1];

            sqlParameters[0] = new OleDbParameter("@id", OleDbType.Integer);
            sqlParameters[0].Value = Convert.ToString(id);

            return conn.executeDeleteQuery(query, sqlParameters);
        }

    }
}
