using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Orden
{
    public class OrdenDAO : DAO
    {
        public OrdenDAO() : base() { }

        public int GetLastOrdenId()
        {
            string query = "SELECT id FROM Ordenes";
            int lastId = 0;
            this.cmd.CommandText = query;

            try
            {
                this.con.Open();
                this.reader = this.cmd.ExecuteReader();
            
                while (this.reader.Read())
                {
                    lastId = int.Parse(reader["id"].ToString());
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
                this.cmd.CommandText = null;
            }

            return lastId;
        }

        public void InsertOrden(double costo, bool tieneMB, bool tieneP, bool tieneCasco, bool tieneLuz)
        {
            string insertStr = "INSERT INTO Ordenes VALUES(@costo, @tieneMB, @tieneP, @tieneCasco, @tieneLuz)";
            this.cmd.CommandText = insertStr;
            this.cmd.Parameters.AddWithValue("@costo", costo);
            this.cmd.Parameters.AddWithValue("@tieneMB", tieneMB);
            this.cmd.Parameters.AddWithValue("@tieneP", tieneP);
            this.cmd.Parameters.AddWithValue("@tieneCasco", tieneCasco);
            this.cmd.Parameters.AddWithValue("@tieneLuz", tieneLuz);

            this.EjecutarNonQuery();
        }
    }
}
