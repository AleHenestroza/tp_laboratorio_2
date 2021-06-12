using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos.Materiales
{
    /// <summary>
    /// Clase Titanio, derivada de Material.
    /// Debe implementar un constructor vacío
    /// </summary>
    [Serializable]
    public class Titanio : Material
    {
        /// <summary>
        /// Constructor vacío de la clase, asigna el nombre y el precio
        /// llamando al constructor de la clase base.
        /// </summary>
        public Titanio() : base("Titanio", (double)EnumCostoMateriales.TITANIO) { }
    }
}
