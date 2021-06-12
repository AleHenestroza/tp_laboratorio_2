using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos.Accesorios
{
    [Serializable]
    public abstract class Accesorio
    {
        private string nombre;
        private double costo;

        public Accesorio(string nombre, double costo)
        {
            this.nombre = nombre;
            this.costo = costo;
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Accesorio: {0}\n", this.nombre);
            return sb.ToString();
        }
    }
}
