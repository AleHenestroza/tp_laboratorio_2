using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades.DAO.Datos
{
    public class StockDAO : DatoDAO
    {
        public StockDAO() : base() { }
        /// <summary>
        /// Recupera los datos de Stock, llamando al método SelectData con los parámetros para recuperar el Stock
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> SelectStock()
        {
            return this.SelectData("nombre", "cantidad", "Stock");
        }
        /// <summary>
        /// Actualiza el Stock en la Base de Datos
        /// </summary>
        /// <param name="valores"></param>
        public void UpdateStock(Dictionary<string, double> valores)
        {
            foreach(KeyValuePair<string, double> dato in valores)
            {
                this.cmd.CommandText = "UPDATE Stock SET cantidad = @value WHERE nombre = @nombre";
                this.cmd.Parameters.AddWithValue("@value", dato.Value);
                this.cmd.Parameters.AddWithValue("@nombre", dato.Key);
                this.EjecutarNonQuery();
            }
        }
    }
}
