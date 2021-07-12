using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades.DAO
{
    /// <summary>
    /// Clase base para todas las clases DAO, tiene una conexión, un comando y un reader y establece la string de conexión a la Base de Datos
    /// </summary>
    public abstract class DAO
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader reader;
        private const string CONNECTION_STR = "Data Source=.;Initial Catalog=TP4_Henestroza_Alejandro;Integrated Security=True";

        public DAO()
        {
            this.con = new SqlConnection(CONNECTION_STR);
            this.cmd = new SqlCommand();
            this.cmd.CommandType = System.Data.CommandType.Text;
            this.cmd.Connection = this.con;
        }

        /// <summary>
        /// Método envolvente para ExecuteNonQuery que maneja posibles excepciones
        /// </summary>
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
