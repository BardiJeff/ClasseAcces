using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsProjet
{
    class AccesExceptionInsert : AccesException
    {
        public AccesExceptionInsert() : base("Erreur à l'insertion des données dans la Base") { }

        public AccesExceptionInsert(string message) : base(message) { }

        public AccesExceptionInsert(string message, Exception innerException) : base(message, innerException) { }

    }
}
