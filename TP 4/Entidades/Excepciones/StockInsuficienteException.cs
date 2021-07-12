using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    /// <summary>
    /// Excepción manejadora para cuando se quiere crear una orden sin contar con el suficiente stock de un material
    /// </summary>
    public class StockInsuficienteException : Exception
    {
        public StockInsuficienteException()
        {
        }

        public StockInsuficienteException(string message) : base(message)
        {
        }

        public StockInsuficienteException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
