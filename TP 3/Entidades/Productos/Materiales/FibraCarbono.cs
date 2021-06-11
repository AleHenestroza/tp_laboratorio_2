using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos.Materiales
{
    /// <summary>
    /// Clase FibraCarbono, derivada de Material.
    /// Debe implementar un constructor vacío
    /// </summary>
    public class FibraCarbono : Material
    {
        /// <summary>
        /// Constructor vacío de la clase, asigna el nombre y el precio
        /// llamando al constructor de la clase base.
        /// </summary>
        public FibraCarbono() : base("Fibra de Carbono", (double)EnumCostoMateriales.CARBONO) { }
    }
}
