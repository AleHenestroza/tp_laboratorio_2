using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Productos.Materiales;

namespace Entidades.Productos.Componentes
{
    /// <summary>
    /// Clase Cuadro, componente de Bicicleta
    /// </summary>
    [Serializable]
    public class Cuadro
    {
        private Material material;
        private double tamanio;
        private double costo;

        /// <summary>
        /// Constructor de Cuadro
        /// Recibe un material y un tamaño
        /// </summary>
        /// <param name="material">Material</param>
        /// <param name="tamanio">Double tamaño</param>
        public Cuadro(Material material, double tamanio)
        {
            this.material = material;
            this.tamanio = tamanio;
            this.costo = material.Costo * tamanio;
        }

        /// <summary>
        /// Getter
        /// </summary>
        public Material Material
        {
            get
            {
                return this.material;
            }
        }
        /// <summary>
        /// Getter
        /// </summary>
        public double Tamanio
        {
            get
            {
                return this.tamanio;
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
        /// <returns>String con los datos completos del cuadro</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n{0}\n", this.Material.ToString());
            sb.AppendFormat("\tTamaño: {0}\n", this.Tamanio);
            sb.AppendFormat("\tCosto: ${0}", this.Costo);
            return sb.ToString();
        }
    }
}
