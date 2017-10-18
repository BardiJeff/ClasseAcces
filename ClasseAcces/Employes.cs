using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAcces
{
    public class Employes
    {
        // PROPERTY

        public int EMPLOYE {get; set; }
        public string NOM { get; set; }
        public string FONCTION { get; set; }
        public int MANAGER{ get; set; }
        public decimal SALAIRE { get; set; }
        public decimal COMM { get; set; }
        public int DEPARTEMENT { get; set; }

        // CONSTRUCTEURS

        public Employes() { }

        public Employes(int empno, string ename, string job, int manager, decimal sal, decimal comm, int deptno)
        {
            this.EMPLOYE = empno;
            this.NOM = ename;
            this.FONCTION = job;
            this.MANAGER = manager;
            this.SALAIRE = sal; 
            this.COMM = comm;           
            this.DEPARTEMENT = deptno;
        }
    }
}
