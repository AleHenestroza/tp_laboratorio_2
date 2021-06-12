using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;
using Entidades.Productos.Materiales;
using Entidades.Productos.Componentes;
using Entidades.Interfaces;

namespace Entidades.Productos
{
    /// <summary>
    /// Clase abstracta genérica Bicicleta
    /// Recibe un Material con un constructor vacío
    /// </summary>
    /// <typeparam name="T">Material</typeparam>
    public abstract class Bicicleta<T> : IFabricable where T : Material, new()
    {
        private Rueda ruedaDelantera;
        private Rueda ruedaTrasera;
        private Cuadro cuadro;
        private double precio;

        /// <summary>
        /// Constructor
        /// Recibe dos ruedas y un tamaño para el cuadro. A la vez, al ser una clase
        /// genérica, se debe especificar el Material al instanciar un objeto.
        /// Si las ruedas tienen distinto rodado, lanza una excepción del tipo
        /// RodadoIncompatibleException
        /// </summary>
        /// <param name="r1">Rueda delantera</param>
        /// <param name="r2">Rueda trasera</param>
        /// <param name="tamanioCuadro">Double Tamaño del cuadro</param>
        public Bicicleta(Rueda r1, Rueda r2, double tamanioCuadro) 
        {
            if (r1.Rodado != r2.Rodado)
            {
                throw new RuedaIncompatibleException("Las ruedas deben tener el mismo rodado.");
            }
            else
            {
                this.ruedaDelantera = r1;
                this.ruedaTrasera = r2;
                this.cuadro = new Cuadro(new T(), tamanioCuadro);
                this.precio = this.ruedaDelantera.Precio + this.ruedaTrasera.Precio + this.cuadro.Precio;
            }
        }

        /// <summary>
        /// Getter y Setter
        /// </summary>
        public Rueda RuedaDelantera
        {
            get
            {
                return this.ruedaDelantera;
            }
            set
            {
                this.ruedaDelantera = value;
            }
        }
        /// <summary>
        /// Getter y Setter
        /// </summary>
        public Rueda RuedaTrasera
        {
            get
            {
                return this.ruedaTrasera;
            }
            set
            {
                this.ruedaTrasera = value;
            }
        }
        /// <summary>
        /// Getter
        /// </summary>
        public Cuadro Cuadro
        {
            get
            {
                return this.cuadro;
            }
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

        public double CalcularCosto()
        {
            return this.Precio;
        }

        public bool EsFabricable(List<double> rodadosValidos)
        {
            if (rodadosValidos.Contains(this.RuedaDelantera.Rodado)
                && rodadosValidos.Contains(this.RuedaTrasera.Rodado))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del método ToString
        /// </summary>
        /// <returns>String con los datos completos de la bicicleta</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n\n----------------------------------------");
            sb.AppendLine(this.GetType().Name);
            sb.AppendFormat("Cuadro: {0}\n", this.cuadro.ToString());
            sb.AppendFormat("Rueda Delantera: {0}\n", this.ruedaDelantera.ToString());
            sb.AppendFormat("Rueda Trasera: {0}\n", this.ruedaTrasera.ToString());
            return sb.ToString();
        }
    }
}
