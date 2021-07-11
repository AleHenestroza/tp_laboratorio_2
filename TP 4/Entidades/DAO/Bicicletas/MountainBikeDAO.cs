using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Productos.Bicicletas;
using Entidades.Productos.Materiales;
using Entidades.Productos.Componentes;

namespace Entidades.DAO.Bicicletas
{
    public class MountainBikeDAO : BicicletaDAO
    {
        public MountainBikeDAO() : base() { }

        public void InsertMountainBike(double rodado, double tamanioCuadro, string material, double costo, bool tieneCambios, int ordenId, int cantidad)
        {
            this.InsertBicicleta("MountainBikes", rodado, tamanioCuadro, material, costo, tieneCambios, ordenId, cantidad);
        }

        public void DeleteMountainBikes(int ordenId)
        {
            this.DeleteBicicletas(ordenId, "MountainBikes");
        }

        protected override IBicicleta RecuperarBicicleta()
        {
            double rodado = double.Parse(this.reader["rodado"].ToString());
            double tamanioCuadro = double.Parse(this.reader["tamanioCuadro"].ToString());
            string material = this.reader["material"].ToString();
            bool tieneCambios = Convert.ToBoolean(int.Parse(this.reader["tieneCambios"].ToString()));

            switch (material)
            {
                case "Acero":
                    return new MountainBike<Acero>(new Rueda(rodado), new Rueda(rodado), tamanioCuadro, tieneCambios);
                    
                case "Aluminio":
                    return new MountainBike<Aluminio>(new Rueda(rodado), new Rueda(rodado), tamanioCuadro, tieneCambios);

                case "Titanio":
                    return new MountainBike<Titanio>(new Rueda(rodado), new Rueda(rodado), tamanioCuadro, tieneCambios);

                case "Fibra de Carbono":
                    return new MountainBike<FibraCarbono>(new Rueda(rodado), new Rueda(rodado), tamanioCuadro, tieneCambios);

                default:
                    return null;
            }
        }

        public List<IBicicleta> SelectMountainBikes(int ordenId)
        {
            return this.SelectBicicletas(ordenId, "MountainBikes");
        }
    }
}
