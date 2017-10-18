using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseExceptions
{
    public class AccesException : Exception
    {
        public AccesException() : base() { }

        public AccesException(string message) : base(message) { }

        public AccesException(string message, Exception innerException) : base(message, innerException) { }

        public override string Message
        {
            get
            {
                return base.Message + " - Message d'origine - ";
            }
        }






    }
}
