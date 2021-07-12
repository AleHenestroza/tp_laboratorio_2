using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Entidades.Productos.Bicicletas;
using Entidades.Productos.Materiales;
using Entidades.Productos.Componentes;

namespace Entidades.DAO.Bicicletas
{
    public class PlayeraDAO : BicicletaDAO
    {
        public PlayeraDAO() : base() { }

        /// <summary>
        /// Inserta una bicicleta, llamando al método InsertBicicletas con los parámetros para una Playera
        /// </summary>
        /// <param name="rodado"></param>
        /// <param name="tamanioCuadro"></param>
        /// <param name="material"></param>
        /// <param name="costo"></param>
        /// <param name="tieneFreno"></param>
        /// <param name="ordenId"></param>
        /// <param name="cantidad"></param>
        public void InsertPlayera(double rodado, double tamanioCuadro, string material, double costo, bool tieneFreno, int ordenId, int cantidad)
        {
            this.InsertBicicleta("Playeras", rodado, tamanioCuadro, material, costo, tieneFreno, ordenId, cantidad);
        }

        /// <summary>
        /// Llama al método DeleteBicicletas con los parámetros para Playera
        /// </summary>
        /// <param name="ordenId"></param>
        public void DeletePlayeras(int ordenId)
        {
            this.DeleteBicicletas(ordenId, "Playeras");
        }

        /// <summary>
        /// Parsea los datos recuperados de la Base de Datos, devolviendo una Playera
        /// </summary>
        /// <returns></returns>
        protected override IBicicleta RecuperarBicicleta()
        {
            double rodado = double.Parse(this.reader["rodado"].ToString());
            double tamanioCuadro = double.Parse(this.reader["tamanioCuadro"].ToString());
            string material = this.reader["material"].ToString();
            bool tieneFrenos = Convert.ToBoolean(int.Parse(this.reader["tieneFrenos"].ToString()));

            switch (material)
            {
                case "Acero":
                    return new Playera<Acero>(new Rueda(rodado), new Rueda(rodado), tamanioCuadro, tieneFrenos);

                case "Aluminio":
                    return new Playera<Aluminio>(new Rueda(rodado), new Rueda(rodado), tamanioCuadro, tieneFrenos);

                case "Titanio":
                    return new Playera<Titanio>(new Rueda(rodado), new Rueda(rodado), tamanioCuadro, tieneFrenos);

                case "Fibra de Carbono":
                    return new Playera<FibraCarbono>(new Rueda(rodado), new Rueda(rodado), tamanioCuadro, tieneFrenos);

                default:
                    return null;
            }
        }
        public List<IBicicleta> SelectPlayeras(int ordenId)
        {
            return this.SelectBicicletas(ordenId, "Playeras");
        }
    }
}
