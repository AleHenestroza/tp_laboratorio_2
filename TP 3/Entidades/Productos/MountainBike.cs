using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Productos.Materiales;
using Entidades.Excepciones;
using Entidades.Productos.Componentes;

namespace Entidades.Productos
{
    /// <summary>
    /// Clase derivada MountainBike, hereda de Bicicleta
    /// </summary>
    /// <typeparam name="T">Material</typeparam>
    [Serializable]
    public class MountainBike<T> : Bicicleta<T> where T : Material, new()
    {
        private static List<double> rodadosValidos = new List<double> { 26, 27, 28 };
        private bool tieneCambios;
        
        /// <summary>
        /// Constructor de la clase MountainBike.
        /// Llama al constructor de la clase base Bicicleta.
        /// Asigna el valor del campo tieneCambios
        /// Si el rodado de las ruedas no es compatible con el tipo de 
        /// bicicleta, lanza una excepción.
        /// </summary>
        /// <param name="r1">Rueda delantera</param>
        /// <param name="r2">Rueda trasera</param>
        /// <param name="tamanioCuadro">Double tamaño del cuadro</param>
        /// <param name="tieneCambios">Bool tiene cambios</param>
        public MountainBike(Rueda r1, Rueda r2, double tamanioCuadro, bool tieneCambios) 
            : base(r1, r2, tamanioCuadro)
        {
            if(!EsFabricable(rodadosValidos))
            {
                throw new RuedaIncompatibleException("El rodado debe ser 26, 27 o 28");
            } 
            else
            {
                this.tieneCambios = tieneCambios;
                if (tieneCambios)
                {
                    this.Precio += 1250;
                }
            }
        }

        /// <summary>
        /// Getter y Setter
        /// </summary>
        public bool TieneCambios
        {
            get
            {
                return this.tieneCambios;
            }
            set
            {
                this.tieneCambios = value;
            }
        }

        /// <summary>
        /// Sobrecarga del método ToString.
        /// Agrega al método de la clase base el campo tieneCambios
        /// </summary>
        /// <returns>String con los datos completos de la bicicleta</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("Tiene cambios: ");
            if (this.tieneCambios)
            {
                sb.AppendLine("SI");
                sb.AppendLine("Costo cambios: $1250");
            }
            else
            {
                sb.AppendLine("NO");
            }
            sb.AppendFormat("\nPrecio Final: ${0}\n", this.Precio);
            return sb.ToString();
        }
    }
}
