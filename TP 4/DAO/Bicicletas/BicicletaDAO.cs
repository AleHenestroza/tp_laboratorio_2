using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Bicicletas
{
    public abstract class BicicletaDAO : DAO
    {
        public BicicletaDAO() : base() { }

        protected void InsertBicicleta(string tabla, double rodado, double tamanioCuadro, string material, double costo, bool tieneCaracteristica, int ordenId, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                string insertStr = "INSERT INTO " + tabla + " VALUES(@rodado, @tamanioCuadro, @material, @costo, @tieneCaracteristica, @ordenId)";
                this.cmd.CommandText = insertStr;
                this.cmd.Parameters.AddWithValue("@rodado", (int)rodado); // El rodado estaba seteado como double en las entidades, pero siempre es un número entero. Antes que cambiarlo en cada clase, me pareció más simple castearlo acá únicamente
                this.cmd.Parameters.AddWithValue("@material", material);
                this.cmd.Parameters.AddWithValue("@tamanioCuadro", tamanioCuadro);
                this.cmd.Parameters.AddWithValue("@costo", costo);
                this.cmd.Parameters.AddWithValue("@tieneCaracteristica", tieneCaracteristica);
                this.cmd.Parameters.AddWithValue("@ordenId", ordenId);

                this.EjecutarNonQuery();
            }
        }

        protected Dictionary<string, string> SelectBicicletas(int ordenId, string tabla, string tieneCaracteristica)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            string selectStr = "SELECT * FROM " + tabla + " WHERE ordenId=@ordenId";
            this.cmd.CommandText = selectStr;
            this.cmd.Parameters.AddWithValue("@ordenId", ordenId);

            try
            {
                this.con.Open();
                this.reader = this.cmd.ExecuteReader();
                int cantidad = 0;
                if (this.reader.HasRows)
                {
                    while (this.reader.Read())
                    {
                        cantidad++;
                    }

                    // Todas las bicicletas de una orden son iguales, lo importante es la cantidad
                    string rodado = reader["rodado"].ToString();
                    string tamanioCuadro = reader["tamanioCuadro"].ToString();
                    string material = reader["material"].ToString();
                    string costo = reader["costo"].ToString();
                    string caracteristica = reader[tieneCaracteristica].ToString();

                    data.Add("rodado", rodado);
                    data.Add("tamanioCuadro", tamanioCuadro);
                    data.Add("material", material);
                    data.Add("costo", costo);
                    data.Add("caracteristica", caracteristica);
                    data.Add("cantidad", cantidad.ToString());
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

            return data;
        }
    }
}
