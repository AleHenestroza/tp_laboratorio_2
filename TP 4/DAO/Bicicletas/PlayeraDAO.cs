using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Bicicletas
{
    public class PlayeraDAO : BicicletaDAO
    {
        public PlayeraDAO() : base() { }

        public void InsertPlayera(double rodado, double tamanioCuadro, string material, double costo, bool tieneFreno, int ordenId, int cantidad)
        {
            this.InsertBicicleta("Playeras", rodado, tamanioCuadro, material, costo, tieneFreno, ordenId, cantidad);
        }

        public Dictionary<string, string> SelectPlayeras(int ordenId)
        {
            return this.SelectBicicletas(ordenId, "Playeras", "tieneFrenos");
        }
    }
}
