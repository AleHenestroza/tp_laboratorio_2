using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public abstract class DAO
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader reader;

        public DAO()
        {
            this.con = new SqlConnection(DBSettings.CONNECTION_STR);
            this.cmd = new SqlCommand();
            this.cmd.CommandType = System.Data.CommandType.Text;
            this.cmd.Connection = this.con;
        }

        protected void EjecutarNonQuery()
        {
            try
            {
                this.con.Open();
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.con.Close();
                this.cmd.Parameters.Clear(); // ¿Hace falta limpiar los parámetros?
                this.cmd.CommandText = null; // ¿Hace falta limpiar el CommandText?
            }
        }
    }
}
