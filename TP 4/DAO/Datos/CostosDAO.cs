using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO.Datos
{
    public class CostosDAO : DatoDAO
    {
        public CostosDAO() : base() { }
        public Dictionary<string, string> SelectCostos()
        {
            return this.SelectData("nombre", "costo", "Costos");
        }

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
