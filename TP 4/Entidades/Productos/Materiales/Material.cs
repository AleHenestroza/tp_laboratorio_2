using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos.Materiales
{
    /// <summary>
    /// Clase abstracta Material
    /// Sus clases derivadas deben implementar un constructor
    /// vacío que llame al constructor con dos parámetros de esta
    /// clase, pasandole los argumentos como constantes.
    /// </summary>
    [Serializable]
    public abstract class Material
    {
        private string nombre;
        private double costo;

        /// <summary>
        /// Constructor de Material
        /// Asigna el nombre y el precio del material.
        /// Las clases derivadas deben implementar un constructor
        /// vacío que llame a este constructor y le pase el nombre
        /// y el precio del material.
        /// </summary>
        /// <param name="nombre">String nombre</param>
        /// <param name="costo">Double precio</param>
        public Material(string nombre, double costo)
        {
            this.nombre = nombre;
            this.costo = costo;
        }
        
        /// <summary>
        /// Getter
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        /// <summary>
        /// Getter y Setter
        /// </summary>
        public double Costo
        {
            get
            {
                return this.costo;
            }
            set
            {
                this.costo = value;
            }
        }

        /// <summary>
        /// Sobrecarga del método ToString.
        /// </summary>
        /// <returns>String con los datos completos del material</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\tMaterial: {0}\n", this.Nombre);
            sb.AppendFormat("\tCosto por unidad de medida: ${0}", this.Costo);
            return sb.ToString();
        }
    }
}
