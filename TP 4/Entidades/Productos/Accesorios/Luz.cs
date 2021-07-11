using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Datos;

namespace Entidades.Productos.Accesorios
{
    [Serializable]
    public class Luz : Accesorio
    {
        private string color;

        public Luz(string color)
            : base("Luz")
        {
            this.color = color;
            this.costo = Costos.CostoLuz;
        }

        public string Color
        {
            get
            {
                return this.color;
            }
        }

        public override double CalcularCosto()
        {
            return this.Costo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat("Color: {0}\n", this.Color);
            sb.AppendFormat("Costo: ${0}\n", this.Costo);
            sb.AppendLine("----------------------------------------\n");
            return sb.ToString();
        }
    }
}
