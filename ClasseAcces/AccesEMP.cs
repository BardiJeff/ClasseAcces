using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClasseAcces
{
    public class AccesEMP
    {

        private static string ConnnectStr = "Data Source=176.31.248.137; Initial Catalog=user10; Persist Security Info=True; User ID=user10; Password=026user10";


        public string ConnectBaseNom(int IdEmploye)
        {
            //     SQLCONNECTION

            SqlConnection connect = new SqlConnection(); // Instanciation de la classe "SqlConnection"
            connect.ConnectionString = ConnnectStr;
            connect.Open();

            //     SQLCOMMAND

            string requete = " SELECT * FROM EMP WHERE EMPNO =" + IdEmploye;

            SqlCommand command = new SqlCommand(requete, connect); // Instanciation de la classe "SqlCommand"

            SqlDataReader reader = command.ExecuteReader(); // ExecuteReader est un curseur placé par défaut au dessus de la 1ère ligne 

            reader.Read(); // read permet le " Move " du curseur 

            return reader.GetString(1);  
        }

        public string ConnectBaseDept (int IdEmploye)
        {
            //     SQLCONNECTION

            SqlConnection connect = new SqlConnection(); // Instanciation de la classe "SqlConnection"
            connect.ConnectionString = ConnnectStr;
            connect.Open();

            //     SQLCOMMAND

            string requete = " SELECT JOB FROM EMP WHERE EMPNO =" + IdEmploye;

            SqlCommand command = new SqlCommand(requete, connect); // Instanciation de la classe "SqlCommand"

            SqlDataReader reader = command.ExecuteReader(); // ExecuteReader est un curseur placé par défaut au dessus de la 1ère ligne 

            reader.Read(); // read permet le " Move " du curseur 

            return reader.GetString(0);
        }













    }
}
