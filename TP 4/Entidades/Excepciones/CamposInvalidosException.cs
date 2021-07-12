using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    /// <summary>
    /// Excepción manejadora de campos inválidos en formulario de GenerarOrden
    /// </summary>
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
