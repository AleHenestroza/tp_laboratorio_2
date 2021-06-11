using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    /// <summary>
    /// Interfaz para productos fabricables
    /// </summary>
    public interface IFabricable
    {
        /// <summary>
        /// Comprueba que el producto haya recibido los parámetros
        /// adecuados para el tipo de producto y retorna si es válida
        /// la producción del mismo.
        /// </summary>
        /// <returns>Bool es posible fabricar</returns>
        bool EsFabricable(List<int> listaValida);
        /// <summary>
        /// Retorna el costo del producto fabricable
        /// </summary>
        /// <returns>Double costo del producto</returns>
        double CalcularCosto();
    }
}
