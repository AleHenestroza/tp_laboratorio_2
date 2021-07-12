using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Productos.Accesorios;

namespace Entidades.DAO.Accesorios
{
    public class CascoDAO : DAO
    {
        public CascoDAO() : base() { }

        /// <summary>
        /// Recupera todos los cascos de una orden por su Id
        /// </summary>
        /// <param name="ordenId"></param>
        /// <returns></returns>
        public List<Casco> SelectCascos(int ordenId)
        {
            List<Casco> cascos = new List<Casco>();
            string selectStr = "SELECT * FROM Cascos WHERE orden_Id=@ordenId";
            this.cmd.CommandText = selectStr;
            this.cmd.Parameters.AddWithValue("@ordenId", ordenId);

            try
            {
                this.con.Open();
                this.reader = this.cmd.ExecuteReader();

                while (this.reader.Read())
                {
                    double talla = double.Parse(this.reader["talla"].ToString());
                    Casco casco = new Casco(talla);
                    cascos.Add(casco);
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

            return cascos;
        }
        /// <summary>
        /// Elimina todos los cascos de una orden por su Id
        /// </summary>
        /// <param name="ordenId"></param>
        public void DeleteCascos(int ordenId)
        {
            string deleteStr = "DELETE FROM Cascos WHERE orden_id=@ordenId";
            this.cmd.CommandText = deleteStr;
            this.cmd.Parameters.AddWithValue("@ordenId", ordenId);

            this.EjecutarNonQuery();
        }
        /// <summary>
        /// Inserta cascos en la BD según la cantidad que haya en la orden
        /// </summary>
        /// <param name="ordenId"></param>
        /// <param name="cantidad"></param>
        /// <param name="costo"></param>
        /// <param name="talla"></param>
        public void InsertCascos(int ordenId, int cantidad, double costo, double talla)
        {
            for (int i = 0; i < cantidad; i++)
            {
                string insertStr = "INSERT INTO Cascos VALUES(@talla, @costo, @ordenId)";
                this.cmd.CommandText = insertStr;
                this.cmd.Parameters.AddWithValue("@talla", talla);
                this.cmd.Parameters.AddWithValue("@costo", costo);
                this.cmd.Parameters.AddWithValue("@ordenId", ordenId);

                this.EjecutarNonQuery();
            }
        }
    }
}
