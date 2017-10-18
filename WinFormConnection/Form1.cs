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
using ClasseExceptions;

namespace WinFormConnection
{
    public partial class Form1 : Form
    {
        // Déclaration des Classes  AccesEMP et AccesEmpList
        AccesEMP Acces;
        AccesEmpList AccesListe;
        AccesDEPT CreatDept;
        AccesDEPT UpdateDept;

        public Form1()
        {
            InitializeComponent();

            // Instanciation des Classes AccesEMP, AccesEmpList et AccesDEPT
            Acces = new AccesEMP();
            AccesListe = new AccesEmpList();
            CreatDept = new AccesDEPT();
            UpdateDept = new AccesDEPT();
        }

        // Action au clic du bouton 1 : Convertion de l'ID employé et exécution de la méthode ConnectBaseNom de la classe Acces
        private void button1_Click(object sender, EventArgs e)
        {
            int idEmploye = Convert.ToInt32(textBoxID.Text);            

            textBox3.Text = Acces.ConnectBaseNom(idEmploye);            
        }

        // Action au clic du bouton JobEmployé : Convertion de l'ID employé et exécution de la méthode ConnectBaseNom de la classe Acces
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
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int numDept = Convert.ToInt32(textBoxNumDept.Text);
                string nomDept = textBoxNomDept.Text;
                string locDept = textBoxLocDept.Text;

                CreatDept.CreateDept(numDept, nomDept, locDept);
            }
            catch (AccesExceptionInsert except)
            {

                MessageBox.Show(except.Message);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int numDept = Convert.ToInt32(textBoxNumDept.Text);
                string nomDept = textBoxNomDept.Text;
                string locDept = textBoxLocDept.Text;

                UpdateDept.UpdateDept(numDept, nomDept, locDept);
            }
            catch (AccesExceptionInsert except)
            {

                MessageBox.Show(except.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
