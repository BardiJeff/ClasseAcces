using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClasseAcces
{
    public class AccesEmpList
    {
        private string ConnnectStr = "Data Source=176.31.248.137; Initial Catalog=user10; Persist Security Info=True; User ID=user10; Password=026user10";

        string requete = " SELECT * FROM EMP ";

        public List<Employes> FindAllEmployes()
        {
            SqlConnection connect = new SqlConnection(); // Instanciation de la classe "SqlConnection"
            connect.ConnectionString = ConnnectStr;
            connect.Open();

            List<Employes> ListeEmp = new List<Employes>();

            //DataSet Table = new DataSet();
            DataTable Table = new DataTable();

            SqlCommand command = new SqlCommand(requete, connect); // Instanciation de la classe "SqlCommand"

            SqlDataAdapter TableAdap = new SqlDataAdapter(command);

            TableAdap.Fill(Table);

            foreach (DataRow champ in Table.Rows)
            {
                int manager = 0;
                
                if(! DBNull.Value.Equals(champ[3]))
                {
                    manager = Convert.ToInt32(champ[3]);
                }

                ListeEmp.Add
                    (new Employes(Convert.ToInt32(champ[0]),
                                  champ[1].ToString(),
                                  manager,
                                  champ[2].ToString(),
                                  Convert.ToInt32(champ[7])
                                 )
                    );
            }
            return ListeEmp;
        }
    }
}
