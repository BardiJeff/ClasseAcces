using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsProjet
{
    class AccesException : Exception
    {       
        public AccesException() : base() { }
        
        public AccesException(string message) : base(message) { }

        public AccesException(string message, Exception innerException) : base(message, innerException) { }
      
    }
}
