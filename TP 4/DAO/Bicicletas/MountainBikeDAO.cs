using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Bicicletas
{
    public class MountainBikeDAO : BicicletaDAO
    {
        public MountainBikeDAO() : base() { }

        public void InsertMountainBike(double rodado, double tamanioCuadro, string material, double costo, bool tieneCambios, int ordenId, int cantidad)
        {
            this.InsertBicicleta("MountainBikes", rodado, tamanioCuadro, material, costo, tieneCambios, ordenId, cantidad);
        }

        public Dictionary<string, string> SelectMountainBikes(int ordenId)
        {
            return this.SelectBicicletas(ordenId, "MountainBikes", "tieneCambios");
        }
    }
}
