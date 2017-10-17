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

        public int Empno {get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public int Manager{ get; set; }
        public decimal Sal { get; set; }
        public int Deptno { get; set; }

        // CONSTRUCTEURS

        public Employes() { }

        public Employes(int empno, string ename, int manager, string job, int deptno)
        {
            this.Empno = empno;
            this.Ename = ename;
            this.Manager = manager;
            this.Job = job;
            this.Deptno = deptno;
        }
    }
}
