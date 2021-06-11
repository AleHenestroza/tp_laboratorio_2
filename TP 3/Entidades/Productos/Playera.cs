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
    /// Clase derivada Playera, hereda de Bicicleta
    /// </summary>
    /// <typeparam name="T">Material</typeparam>
    public class Playera<T> : Bicicleta<T> where T : Material, new()
    {
        private static List<int> rodadosValidos = new List<int> { 20, 22, 24, 26, 27, 28 };
        private bool frenoContraPedal;

        /// <summary>
        /// Constructor de la clase Playera.
        /// Llama al constructor de la clase base Bicicleta.
        /// Asigna el valor del campo frenoContraPedal
        /// Si el rodado no es compatible con la bicicleta, lanza una excepción
        /// </summary>
        /// <param name="r1">Rueda delantera</param>
        /// <param name="r2">Rueda trasera</param>
        /// <param name="tamanioCuadro">Double tamaño del cuadro</param>
        /// <param name="frenoContraPedal">Bool tiene freno contra pedal</param>
        public Playera(Rueda r1, Rueda r2, double tamanioCuadro, bool frenoContraPedal) 
            : base(r1, r2, tamanioCuadro)
        {
            if(!EsFabricable(rodadosValidos))
            {
                throw new RuedaIncompatibleException("El rodado debe ser 20, 22, 24, 26, 28");
            }
            else
            {
                this.frenoContraPedal = frenoContraPedal;
                if (!frenoContraPedal)
                {
                    this.Precio += 850;
                }
            }
        }

        /// <summary>
        /// Getter y Setter
        /// </summary>
        public bool FrenoContraPedal
        {
            get
            {
                return this.frenoContraPedal;
            }
            set
            {
                this.frenoContraPedal = value;
            }
        }

        /// <summary>
        /// Sobrecarga del método ToString.
        /// Agrega al método de la clase base el campo frenoContraPedal
        /// </summary>
        /// <returns>String con los datos completos de la bicicleta</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("Freno contra pedal: ");
            if (this.frenoContraPedal)
            {
                sb.AppendLine("SI");
            }
            else
            {
                sb.AppendLine("NO");
                sb.AppendLine("Costo frenos: $850");
            }
            sb.AppendFormat("\nPrecio Final: ${0}\n", this.Precio);
            return sb.ToString();
        }
    }
}
