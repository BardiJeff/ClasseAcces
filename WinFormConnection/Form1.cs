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
using ClasseAcces;

namespace WinFormConnection
{
    public partial class Form1 : Form
    {
        AccesEMP Acces;
        AccesEmpList AccesListe;

        public Form1()
        {
            InitializeComponent();
            Acces = new AccesEMP();
            AccesListe = new AccesEmpList();

        } 

        private void button1_Click(object sender, EventArgs e)
        {
            int idEmploye = Convert.ToInt32(textBoxID.Text);            

            textBox3.Text = Acces.ConnectBaseNom(idEmploye);            
        }

        private void JobEmployé_Click(object sender, EventArgs e)
        {
            int idEmploye = Convert.ToInt32(textBoxID.Text);

            textBox4.Text = Acces.ConnectBaseDept(idEmploye);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Employes> Maliste = AccesListe.FindAllEmployes();

            dataGridView1.DataSource = Maliste;
            
        }
    }
}
