using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClasseAccesEMP
{
    public class AccesEMP
    {

        private static string ConnnectStr = "Data Source=176.31.248.137; Initial Catalog=user10; Persist Security Info=True; User ID=user10; Password=026user10";

        public void ConnectBase()
        {
            //     SQLCONNECTION

            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = ConnnectStr;
            connect.Open();

            //     SQLCOMMAND

            String requete = " SELECT * FROM EMP WHERE EMPNO = 7839";

            SqlCommand command = new SqlCommand(requete, connect);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

            Console.WriteLine(String.Format("{0}, {1}, {2}", reader[0], reader[1], reader[2]));

            } 
        }
    }
}
