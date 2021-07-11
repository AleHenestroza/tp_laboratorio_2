using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Orden;
using Entidades.DAO.Bicicletas;
using Entidades.DAO.Accesorios;
using Entidades.Productos.Accesorios;
using Interfaces;

namespace Entidades.DAO.Orden
{
    public class OrdenDAO : DAO
    {
        public OrdenDAO() : base() { }

        /// <summary>
        /// Recupera el último id ingresado en la base de datos
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Guarda la Orden en la Base de Datos.
        /// </summary>
        /// <param name="costo"></param>
        /// <param name="tieneMB"></param>
        /// <param name="tieneP"></param>
        /// <param name="tieneCasco"></param>
        /// <param name="tieneLuz"></param>
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
        /// <summary>
        /// Recupera todas las ordenes de la Base de Datos y las asigna a un objeto ListOrden
        /// </summary>
        /// <returns></returns>
        public ListOrden SelectOrdenes()
        {
            List<Entidades.Orden.Orden> listadoOrdenes = new List<Entidades.Orden.Orden>();
            string selectStr = "SELECT * FROM Ordenes";
            this.cmd.CommandText = selectStr;
            
            try
            {
                this.con.Open();
                this.reader = this.cmd.ExecuteReader();

                if (this.reader.HasRows)
                {
                    while (this.reader.Read())
                    {
                        int ordenId = int.Parse(this.reader["id"].ToString());
                        IBicicleta mb = null;
                        int cantMB = 0;
                        IBicicleta p = null;
                        int cantP = 0;
                        IFabricable casco = null;
                        int cantCasco = 0;
                        IFabricable luz = null;
                        int cantLuz = 0;
                        if (this.reader["tieneMountainBike"].ToString() == "1")
                        {
                            MountainBikeDAO mbDAO = new MountainBikeDAO();
                            List<IBicicleta> mountainBikes = mbDAO.SelectMountainBikes(ordenId);
                            mb = mountainBikes.First();
                            cantMB = mountainBikes.Count;
                        }
                        if (this.reader["tienePlayera"].ToString() == "1")
                        {
                            PlayeraDAO pDAO = new PlayeraDAO();
                            List<IBicicleta> playeras = pDAO.SelectPlayeras(ordenId);
                            p = playeras.First();
                            cantP = playeras.Count;
                        }
                        if (this.reader["tieneCasco"].ToString() == "1")
                        {
                            CascoDAO cDAO = new CascoDAO();
                            List<Casco> cascos = cDAO.SelectCascos(ordenId);
                            casco = cascos.First();
                            cantCasco = cascos.Count;
                        }
                        if (this.reader["tieneLuz"].ToString() == "1")
                        {
                            LuzDAO lDAO = new LuzDAO();
                            List<Luz> luces = lDAO.SelectLuces(ordenId);
                            luz = luces.First();
                            cantLuz = luces.Count;
                        }

                        Entidades.Orden.Orden nuevaOrden = new Entidades.Orden.Orden(ordenId, mb, cantMB, p, cantP, casco, cantCasco, luz, cantLuz);
                        listadoOrdenes.Add(nuevaOrden);
                    }
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

            ListOrden listOrden = new ListOrden(listadoOrdenes);
            return listOrden;
        }
        /// <summary>
        /// Elimina la orden y todos los componentes asociados a ella
        /// </summary>
        /// <param name="ordenId"></param>
        public void DeleteOrden(int ordenId)
        {
            string tieneMB = "0";
            string tieneP = "0";
            string tieneCasco = "0";
            string tieneLuz = "0";

            string selectOrden = "SELECT * FROM Ordenes WHERE id=@ordenId";
            this.cmd.CommandText = selectOrden;
            this.cmd.Parameters.AddWithValue("@ordenId", ordenId);

            // Reviso si la orden tiene bicicletas o accesorios.
            try
            {
                this.con.Open();
                this.reader = this.cmd.ExecuteReader();
                
                if (this.reader.HasRows)
                {
                    while (this.reader.Read())
                    {
                        tieneMB = this.reader["tieneMountainBike"].ToString();
                        tieneP = this.reader["tienePlayera"].ToString();
                        tieneCasco = this.reader["tieneCasco"].ToString();
                        tieneLuz = this.reader["tieneLuz"].ToString();
                    }
                }
                else
                {
                    this.reader.Close();
                    throw new Exception("La orden no está guardada en la Base de Datos");
                }
                this.reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.con.Close();
                this.cmd.Parameters.Clear();
                this.cmd.CommandText = null;
            }

            // Elimino las bicicletas y los accesorios
            if (tieneMB == "1")
            {
                MountainBikeDAO mbDAO = new MountainBikeDAO();
                mbDAO.DeleteMountainBikes(ordenId);
            }
            if (tieneP == "1")
            {
                PlayeraDAO pDAO = new PlayeraDAO();
                pDAO.DeletePlayeras(ordenId);
            }
            if (tieneCasco == "1")
            {
                CascoDAO cDAO = new CascoDAO();
                cDAO.DeleteCascos(ordenId);
            }
            if (tieneLuz == "1")
            {
                LuzDAO lDAO = new LuzDAO();
                lDAO.DeleteLuces(ordenId);
            }

            // Elimino la orden de la Base de Datos
            string deleteStr = "DELETE FROM Ordenes WHERE id=@ordenId";
            this.cmd.CommandText = deleteStr;
            this.cmd.Parameters.AddWithValue("@ordenId", ordenId);
            this.EjecutarNonQuery();

        }

    }
}
