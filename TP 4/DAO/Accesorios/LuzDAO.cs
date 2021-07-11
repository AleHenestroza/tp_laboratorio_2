using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Accesorios
{
    public class LuzDAO : DAO
    {
        public LuzDAO() : base() { }

        public Dictionary<string, int> SelectLuces(int ordenId)
        {
            return null;
        }

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
