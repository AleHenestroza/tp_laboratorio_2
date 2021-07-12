using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades.Productos.Accesorios
{
    [Serializable]
    public abstract class Accesorio : IFabricable
    {
        protected string nombre;
        protected double costo;

        public Accesorio(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
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

        public abstract double CalcularCosto();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Accesorio: {0}\n", this.Nombre);
            return sb.ToString();
        }
    }
}
