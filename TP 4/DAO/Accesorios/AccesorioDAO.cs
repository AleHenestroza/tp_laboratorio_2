using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Accesorios
{
    public abstract class AccesorioDAO : DAO
    {
        public AccesorioDAO() : base() { }

        protected virtual Dictionary<string, string> SelectData(int ordenId, string colName, string tabla)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            this.cmd.CommandText = "SELECT * FROM " + tabla + " WHERE orden_id = @ordenId";
            this.cmd.Parameters.AddWithValue("@ordenId", ordenId);

            try
            {
                this.con.Open();
                this.reader = this.cmd.ExecuteReader();
                
                while(reader.Read())
                {
                    string colAux = reader[colName].ToString();
                    string costoAux = reader["costo"].ToString();
                    data.Add(colAux, costoAux);
                }
                this.reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al seleccionar campos de la Base de Datos");
            }
            finally
            {
                this.con.Close();
                this.cmd.CommandText = null;
            }

            return data;
        }
    }
}
