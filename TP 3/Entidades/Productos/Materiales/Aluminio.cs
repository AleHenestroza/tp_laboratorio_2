using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos.Materiales
{
    /// <summary>
    /// Clase Aluminio, derivada de Material.
    /// Debe implementar un constructor vacío
    /// </summary>
    [Serializable]
    public class Aluminio : Material
    {
        /// <summary>
        /// Constructor vacío de la clase, asigna el nombre y el precio
        /// llamando al constructor de la clase base.
        /// </summary>
        public Aluminio() : base("Aluminio", (double)EnumCostoMateriales.ALUMINIO) { }
    }
}
