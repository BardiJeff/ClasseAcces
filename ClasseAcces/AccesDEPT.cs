using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClasseExceptions;

namespace ClasseAcces
{
    public class AccesDEPT
    {
        private static string ConnnectStr = "Data Source=176.31.248.137; Initial Catalog=user10; Persist Security Info=True; User ID=user10; Password=026user10";

        public int CreateDept(int numDept, string nomDept, string locDept)
        {
            //     SQLCONNECTION

            SqlConnection connect = new SqlConnection(); // Instanciation de la classe "SqlConnection"
            connect.ConnectionString = ConnnectStr;
            connect.Open();

            int resultat = 0;                   

            //     TEST : Si département existant dans la base

            string requete1 = " SELECT DEPTNO FROM DEPT WHERE DEPTNO = " + numDept;

            SqlCommand command = new SqlCommand(requete1, connect); // Instanciation de la classe "SqlCommand"                        
            //command.Connection.Open();           

            int NbLigne =  command.ExecuteNonQuery();

            if (NbLigne != 0)
            {
                //      EXECUTION DE LA REQUETE INSERT
                string requete2 = " INSERT INTO DEPT VALUES ( '" + numDept + "','" + nomDept + "', '" + locDept + "') ";

                try
                {
                    SqlCommand command2 = new SqlCommand(requete2, connect); // Instanciation de la classe "SqlCommand"
                    resultat = command2.ExecuteNonQuery();
                    connect.Close();
                }
                catch (SqlException except)
                {
                    throw new AccesExceptionInsert("Insertion impossible  -  ", except);
                }

            }
            return resultat;
        }

        public int UpdateDept(int numDept, string nomDept, string locDept)
        {

            int resultat2 = 0;

            //     SQLCONNECTION

            SqlConnection connect = new SqlConnection(); // Instanciation de la classe "SqlConnection"
            connect.ConnectionString = ConnnectStr;
            connect.Open();

            string requete3 = " UPDATE DEPT SET DNAME = '" + nomDept + "', LOC = '" + locDept + "' WHERE DEPTNO = '" + numDept + "'";

            try
            {
                SqlCommand command3 = new SqlCommand(requete3, connect); // Instanciation de la classe "SqlCommand"
                resultat2 = command3.ExecuteNonQuery();
                connect.Close();
            }
            catch (SqlException except)
            {
                throw new AccesExceptionInsert("Modification impossible  -  ", except);
            }
            return resultat2;
        }
    }
}
