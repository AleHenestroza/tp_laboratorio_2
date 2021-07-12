using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades.DAO.Datos
{
    public class CostosDAO : DatoDAO
    {
        public CostosDAO() : base() { }
        /// <summary>
        /// Llama al método SelectData con los parámetros necesarios para recuperar los costos
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> SelectCostos()
        {
            return this.SelectData("nombre", "costo", "Costos");
        }
        /// <summary>
        /// Recibe todos los costos de la aplicación en un diccionario y actualiza los campos existentes en la Base de Datos con los nuevos valores
        /// </summary>
        /// <param name="valores"></param>
        public void UpdateCostos(Dictionary<string, double> valores)
        {
            foreach(KeyValuePair<string, double> dato in valores)
            {
                this.cmd.CommandText = "UPDATE Costos SET costo = @value WHERE nombre = @nombre";
                this.cmd.Parameters.AddWithValue("@value", dato.Value);
                this.cmd.Parameters.AddWithValue("@nombre", dato.Key);
                this.EjecutarNonQuery();
            }
        }
    }
}
