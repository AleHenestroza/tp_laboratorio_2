using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CamposInvalidosException : Exception
    {
        public CamposInvalidosException()
        {
        }

        public CamposInvalidosException(string message) : base(message)
        {
        }

        public CamposInvalidosException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
