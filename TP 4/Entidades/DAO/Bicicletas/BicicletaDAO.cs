using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Productos.Bicicletas;
using Entidades.Productos.Materiales;
using Entidades.Productos.Componentes;
using Interfaces;

namespace Entidades.DAO.Bicicletas
{
    public abstract class BicicletaDAO : DAO
    {
        public BicicletaDAO() : base() { }

        /// <summary>
        /// Inserta una cantidad de bicicletas en la tabla correspondiente
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="rodado"></param>
        /// <param name="tamanioCuadro"></param>
        /// <param name="material"></param>
        /// <param name="costo"></param>
        /// <param name="tieneCaracteristica"></param>
        /// <param name="ordenId"></param>
        /// <param name="cantidad"></param>
        protected void InsertBicicleta(string tabla, double rodado, double tamanioCuadro, string material, double costo, bool tieneCaracteristica, int ordenId, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                string insertStr = "INSERT INTO " + tabla + " VALUES(@rodado, @tamanioCuadro, @material, @costo, @tieneCaracteristica, @ordenId)";
                this.cmd.CommandText = insertStr;
                this.cmd.Parameters.AddWithValue("@rodado", (int)rodado); // El rodado estaba seteado como double en las entidades, pero siempre es un número entero. Antes que cambiarlo en cada clase, me pareció más simple castearlo acá únicamente
                this.cmd.Parameters.AddWithValue("@material", material);
                this.cmd.Parameters.AddWithValue("@tamanioCuadro", tamanioCuadro);
                this.cmd.Parameters.AddWithValue("@costo", costo);
                this.cmd.Parameters.AddWithValue("@tieneCaracteristica", tieneCaracteristica);
                this.cmd.Parameters.AddWithValue("@ordenId", ordenId);

                this.EjecutarNonQuery();
            }
        }

        /// <summary>
        /// Recupera un listado de bicicletas en base al Id de la orden
        /// </summary>
        /// <param name="ordenId"></param>
        /// <param name="tabla"></param>
        /// <returns></returns>
        protected List<IBicicleta> SelectBicicletas(int ordenId, string tabla)
        {
            List<IBicicleta> bicicletas = new List<IBicicleta>();

            string selectStr = "SELECT * FROM " + tabla + " WHERE ordenId=@ordenId";
            this.cmd.CommandText = selectStr;
            this.cmd.Parameters.AddWithValue("@ordenId", ordenId);

            try
            {
                this.con.Open();
                this.reader = this.cmd.ExecuteReader();

                while (this.reader.Read())
                {
                    IBicicleta bicicleta = this.RecuperarBicicleta();
                    bicicletas.Add(bicicleta);
                }
                this.reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.con.Close();
                this.cmd.Parameters.Clear();
                this.cmd.CommandText = null;
            }

            return bicicletas;
        }
        /// <summary>
        /// Elimina las bicicletas de una orden
        /// </summary>
        /// <param name="ordenId"></param>
        /// <param name="tabla"></param>
        protected void DeleteBicicletas(int ordenId, string tabla)
        {
            string deleteStr = "DELETE FROM " + tabla + " WHERE ordenId=@ordenId";
            this.cmd.CommandText = deleteStr;
            this.cmd.Parameters.AddWithValue("@ordenId", ordenId);

            this.EjecutarNonQuery();
        }
        /// <summary>
        /// Tras hacer el SELECT de bicicletas, crea un objeto bicicleta en base a los parámetros recueprados
        /// </summary>
        /// <returns></returns>
        protected abstract IBicicleta RecuperarBicicleta();

    }
}
