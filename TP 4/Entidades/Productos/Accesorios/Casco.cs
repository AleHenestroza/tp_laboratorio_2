using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Datos;

namespace Entidades.Productos.Accesorios
{
    [Serializable]
    public class Casco : Accesorio
    {
        private double talla;

        public Casco(double talla)
            : base("Casco")
        {
            this.talla = talla;
            this.costo = this.Talla * 0.025 * Costos.CostoCasco;
        }

        public double Talla
        {
            get
            {
                return this.talla;
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
            sb.AppendFormat("Diámetro: {0}\n", this.Talla);
            sb.AppendFormat("Costo: ${0}\n", this.Costo);
            sb.AppendLine("----------------------------------------\n");
            return sb.ToString();
        }
    }
}
