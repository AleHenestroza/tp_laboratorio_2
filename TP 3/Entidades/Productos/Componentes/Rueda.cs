using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos.Componentes
{
    /// <summary>
    /// Clase Rueda, componente de Bicicleta
    /// </summary>
    [Serializable]
    public class Rueda
    {
        private double precio;
        private double rodado;

        /// <summary>
        /// Constructor de Rueda
        /// Asigna el rodado y determina el precio multiplicando el rodado
        /// por un valor arbitrario (a futuro, debería definirse en una tabla
        /// "configuración" en una Base de Datos)
        /// </summary>
        /// <param name="rodado"></param>
        public Rueda(double rodado)
        {
            this.rodado = rodado;
            this.precio = rodado * 110.75;
        }

        /// <summary>
        /// Getter y Setter
        /// </summary>
        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
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
            sb.AppendFormat("\n\tRodado {0}", this.rodado);
            sb.AppendFormat("\n\tCosto: ${0}", this.precio);
            return sb.ToString();
        }
    }
}
