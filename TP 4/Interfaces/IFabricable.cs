using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /// <summary>
    /// Interfaz para productos fabricables
    /// </summary>
    public interface IFabricable
    {
        /// <summary>
        /// Retorna el costo del producto fabricable.
        /// La razón de este método es poder listar todos los productos fabricables, ya sean
        /// bicicletas o accesorios, y poder obtener el costo de cada uno. En sí mismo, actúa como un
        /// getter, pero al crear una lista de IFabricable, expone el método para ser llamado sin especificar
        /// el tipo concreto de dato.
        /// </summary>
        /// <returns>Double costo del producto</returns>
        double CalcularCosto();
    }
}
