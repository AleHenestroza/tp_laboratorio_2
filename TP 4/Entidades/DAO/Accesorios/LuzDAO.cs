using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Productos.Accesorios;

namespace Entidades.DAO.Accesorios
{
    public class LuzDAO : DAO
    {
        public LuzDAO() : base() { }

        /// <summary>
        /// Recupera todas las luces de una orden por su Id
        /// </summary>
        /// <param name="ordenId"></param>
        /// <returns></returns>
        public List<Luz> SelectLuces(int ordenId)
        {
            List<Luz> luces = new List<Luz>();
            string selectStr = "SELECT * FROM Luces WHERE ordenId=@ordenId";
            this.cmd.CommandText = selectStr;
            this.cmd.Parameters.AddWithValue("@ordenId", ordenId);

            try
            {
                this.con.Open();
                this.reader = this.cmd.ExecuteReader();

                while (this.reader.Read())
                {
                    string color = this.reader["color"].ToString();
                    Luz luz = new Luz(color);
                    luces.Add(luz);
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

            return luces;
        }
        /// <summary>
        /// Borra todas las luces de una orden por su Id
        /// </summary>
        /// <param name="ordenId"></param>
        public void DeleteLuces(int ordenId)
        {
            string deleteStr = "DELETE FROM Luces WHERE ordenId=@ordenId";
            this.cmd.CommandText = deleteStr;
            this.cmd.Parameters.AddWithValue("@ordenId", ordenId);

            this.EjecutarNonQuery();
        }
        /// <summary>
        /// Inserta luces en la base de datos dependiendo de la cantidad
        /// </summary>
        /// <param name="ordenId"></param>
        /// <param name="cantidad"></param>
        /// <param name="costo"></param>
        /// <param name="color"></param>
        public void InsertLuz(int ordenId, int cantidad, double costo, string color)
        {
            for (int i = 0; i < cantidad; i++)
            {
                string insertStr = "INSERT INTO Luces VALUES(@color, @costo, @ordenId)";
                this.cmd.CommandText = insertStr;
                this.cmd.Parameters.AddWithValue("@color", color);
                this.cmd.Parameters.AddWithValue("@costo", costo);
                this.cmd.Parameters.AddWithValue("@ordenId", ordenId);
                this.EjecutarNonQuery();
            }
        }
    }
}
