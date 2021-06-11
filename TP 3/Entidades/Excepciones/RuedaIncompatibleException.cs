using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    /// <summary>
    /// Excepción que se lanza cuando una bicicleta se instancia con dos ruedas
    /// con distinto rodado.
    /// </summary>
    public class RuedaIncompatibleException : Exception
    {
        public RuedaIncompatibleException()
        {
        }

        public RuedaIncompatibleException(string message) : base(message)
        {
        }

        public RuedaIncompatibleException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
