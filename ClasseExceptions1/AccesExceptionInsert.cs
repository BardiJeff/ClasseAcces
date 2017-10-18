using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseExceptions
{
    public class AccesExceptionInsert : AccesException
    {
        public AccesExceptionInsert() : base() { }

        public AccesExceptionInsert(string message) : base(message) { }

        public AccesExceptionInsert(string message, Exception innerException) : base(message, innerException) { }

        public override string Message
        {
            get
            {
                return base.Message + " Erreur à l'insertion des données dans la Base";
            }
        }

    }
}