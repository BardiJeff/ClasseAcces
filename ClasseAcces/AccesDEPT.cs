using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClasseAcces
{
    public class AccesDEPT
    {
        private static string ConnnectStr = "Data Source=176.31.248.137; Initial Catalog=user10; Persist Security Info=True; User ID=user10; Password=026user10";

        public void CreateDept(int numDept, string nomDept, string locDept)
        {
            //     SQLCONNECTION

            SqlConnection connect = new SqlConnection(); // Instanciation de la classe "SqlConnection"
            connect.ConnectionString = ConnnectStr;
            connect.Open();           

            //     TEST : Si département existant dans la base

            string requete1 = " SELECT DEPTNO FROM DEPT WHERE DEPTNO = " + numDept;

            SqlCommand command = new SqlCommand(requete1, connect); // Instanciation de la classe "SqlCommand"                        
            //command.Connection.Open();           

            int NbLigne =  command.ExecuteNonQuery();                        

            if (NbLigne != 0)
            {  
                //      EXECUTION DE LA REQUETE INSERT
                string requete2 = " INSERT INTO DEPT VALUES ( '" + numDept + "','" + nomDept + "', '" + locDept + "') ";
                
                SqlCommand command2 = new SqlCommand(requete2, connect); // Instanciation de la classe "SqlCommand"

                //command2.Connection.Open();
                command2.ExecuteNonQuery();
                connect.Close();



                ////      EXECUTION DE LA REQUETE SELECT pour ramener les valeurs du nouvel insert
                //string requete3 = " SELECT * FROM DEPT WHERE DEPTNO = " + numDept;

                //SqlCommand command3 = new SqlCommand(requete2, connect); // Instanciation de la classe "SqlCommand"

                //SqlDataReader reader = command.ExecuteReader(); // ExecuteReader est un curseur placé par défaut au dessus de la 1ère ligne 

                //reader.Read(); // read permet le " Move " du curseur 

                //return reader.GetString(0);

            }
        }
    }
}
