using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Datos;

namespace Entidades.Productos.Componentes
{
    /// <summary>
    /// Clase Rueda, componente de Bicicleta
    /// </summary>
    [Serializable]
    public class Rueda
    {
        private double costo;
        private double rodado;

        /// <summary>
        /// Constructor de Rueda
        /// Asigna el rodado y determina el precio multiplicando el rodado
        /// por el valor establecido en la Base de Datos
        /// </summary>
        /// <param name="rodado"></param>
        public Rueda(double rodado)
        {
            this.rodado = rodado;
            this.costo = rodado * Costos.CostoRueda;
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
        /// Getter
        /// </summary>
        public double Rodado
        {
            get
            {
                return this.rodado;
            }
        }

        /// <summary>
        /// Sobrecarga del método ToString
        /// </summary>
        /// <returns>String con los datos completos de la Rueda</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n\tRodado {0}", this.Rodado);
            sb.AppendFormat("\n\tCosto: ${0}", this.Costo);
            return sb.ToString();
        }
    }
}
