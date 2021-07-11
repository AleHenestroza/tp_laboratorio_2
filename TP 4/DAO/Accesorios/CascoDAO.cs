using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Accesorios
{
    public class CascoDAO : AccesorioDAO
    {
        public CascoDAO() : base() { }

        public Dictionary<string, int> SelectCascos(int ordenId)
        {
            return null;
        }

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
