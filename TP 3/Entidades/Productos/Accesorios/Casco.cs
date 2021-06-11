using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos.Accesorios
{
    public class Casco : Accesorio
    {
        private double diametro;

        public Casco(double diametro) 
            : base("Casco", (double)EnumCostoAccesorios.CASCO)
        {
            this.diametro = diametro;
        }

        public double Diametro
        {
            get
            {
                return this.diametro;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat("Diámetro: {0}\n", this.diametro);
            sb.AppendFormat("Costo: ${0}\n", this.Costo);
            sb.AppendLine("------------------------");
            return sb.ToString();
        }
    }
}
