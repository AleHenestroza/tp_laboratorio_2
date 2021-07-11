using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades.DAO.Datos
{
    public abstract class DatoDAO : DAO
    {
        public DatoDAO() : base() { }

        protected virtual Dictionary<string, string> SelectData(string nombre, string valor, string tabla)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            this.cmd.CommandText = $"SELECT * FROM " + tabla;
            try
            {
                this.con.Open();
                this.reader = this.cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nombreAux = reader[nombre].ToString();
                    string valorAux = reader[valor].ToString();
                    data.Add(nombreAux, valorAux);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
