using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormConnection
{
    public partial class Form1 : Form
    {
        private static string ConnnectStr = "Data Source=176.31.248.137; Initial Catalog=user10; Persist Security Info=True; User ID=user10; Password=026user10";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //     SQLCONNECTION

            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = ConnnectStr;
            connect.Open();

            //     SQLCOMMAND

            String requete = " SELECT ENAME FROM EMP WHERE EMPNO = 7839";

            SqlCommand command = new SqlCommand(requete, connect);

            SqlDataReader reader = command.ExecuteReader();


            //reader.NextResult();
            reader.Read();
            textBoxNOM.Text = string.Format("Le Nom est : {0} ", reader.GetValue(0));

            
            connect.Close();

        }
    }
}
