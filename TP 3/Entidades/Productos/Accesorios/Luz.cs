using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos.Accesorios
{
    public class Luz : Accesorio
    {
        private string color;

        public Luz(string color)
            : base("Luz", (double)EnumCostoAccesorios.LUZ)
        {
            this.color = color;
        }

        public string Color
        {
            get
            {
                return this.color;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat("Color: {0}\n", this.color);
            sb.AppendFormat("Costo: ${0}\n", this.Costo);
            sb.AppendLine("------------------------");
            return sb.ToString();
        }
    }
}
