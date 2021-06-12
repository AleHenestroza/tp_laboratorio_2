using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos.Accesorios
{
    public class Casco : Accesorio
    {
        private double talla;

        public Casco(double talla) 
            : base("Casco", (double)EnumCostoAccesorios.CASCO)
        {
            this.talla = talla;
            this.Costo = talla * 0.025 * (double)EnumCostoAccesorios.CASCO;
        }

        public double Talla
        {
            get
            {
                return this.talla;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat("Diámetro: {0}\n", this.talla);
            sb.AppendFormat("Costo: ${0}\n", this.Costo);
            sb.AppendLine("----------------------------------------\n");
            return sb.ToString();
        }
    }
}
