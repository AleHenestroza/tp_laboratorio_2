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

        /// <summary>
        /// Llama al método InsertBicicleta con los parámetros para una MountainBike
        /// </summary>
        /// <param name="rodado"></param>
        /// <param name="tamanioCuadro"></param>
        /// <param name="material"></param>
        /// <param name="costo"></param>
        /// <param name="tieneCambios"></param>
        /// <param name="ordenId"></param>
        /// <param name="cantidad"></param>
        public void InsertMountainBike(double rodado, double tamanioCuadro, string material, double costo, bool tieneCambios, int ordenId, int cantidad)
        {
            this.InsertBicicleta("MountainBikes", rodado, tamanioCuadro, material, costo, tieneCambios, ordenId, cantidad);
        }

        /// <summary>
        /// Llama al método DeleteBicicletas con los parámetros para una MountainBike
        /// </summary>
        /// <param name="ordenId"></param>
        public void DeleteMountainBikes(int ordenId)
        {
            this.DeleteBicicletas(ordenId, "MountainBikes");
        }

        /// <summary>
        /// Parsea los datos recuperados de la tabla MountainBike, devolviendo una MountainBike con los campos correctos
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Llama al método SelectBicicletas con los parámetros para una MountainBike
        /// </summary>
        /// <param name="ordenId"></param>
        /// <returns></returns>
        public List<IBicicleta> SelectMountainBikes(int ordenId)
        {
            return this.SelectBicicletas(ordenId, "MountainBikes");
        }
    }
}
