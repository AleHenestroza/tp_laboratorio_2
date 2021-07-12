using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Entidades.Orden;
using Entidades.Datos;
using Entidades.Excepciones;
using Entidades.DAO.Orden;

namespace Entidades
{
    public static class Fabrica
    {
        private static ListOrden listadoOrdenes;
        static Fabrica()
        {
            listadoOrdenes = new ListOrden();
        }
        public static ListOrden ListadoOrdenes
        {
            get { return listadoOrdenes; }
            set { listadoOrdenes = value; }
        }
        public static int CantidadOrdenes
        {
            get
            {
                return ListadoOrdenes.ListadoOrdenes.Count;
            }
        }
        /// <summary>
        /// Recibe un filestream por parámetro y exporta el ListOrden a un archivo binario en la ubicacion que se haya indicado en el filestream
        /// </summary>
        /// <param name="path"></param>
        public static void ExportarBinario(Stream fs)
        {
            BinaryFormatter ser;

            ser = new BinaryFormatter();
            ser.Serialize(fs, listadoOrdenes);
            fs.Close();
        }
        /// <summary>
        /// Importa un archivo binario en el path indicado y recupera el ListOrden
        /// </summary>
        /// <param name="path"></param>
        public static void ImportarBinario(string path)
        {
            Stream fs;
            BinaryFormatter ser;

            fs = new FileStream(path, FileMode.Open);
            ser = new BinaryFormatter();
            listadoOrdenes = (ListOrden)ser.Deserialize(fs);
            fs.Close();

        }
        /// <summary>
        /// Recupera un ListOrden a partir de las ordenes guardadas en la Base de Datos
        /// </summary>
        public static void ImportarOrdenesDB()
        {
            OrdenDAO ordenDAO = new OrdenDAO();
            ListadoOrdenes = ordenDAO.SelectOrdenes();
        }
        /// <summary>
        /// Revisa que haya suficiente stock de un material
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="material"></param>
        /// <returns></returns>
        private static bool HaySuficienteMaterial(double cantidad, string material) 
        {
            switch (material)
            {
                case "Acero":
                    return cantidad <= Stock.CantAcero;
                case "Aluminio":
                    return cantidad <= Stock.CantAluminio;
                case "Titanio":
                    return cantidad <= Stock.CantTitanio;
                case "Fibra de Carbono":
                    return cantidad <= Stock.CantCarbono;
                default:
                    return false;
            }
        }
        /// <summary>
        /// Actualiza el Stock en la aplicación en base al material
        /// </summary>
        /// <param name="material"></param>
        /// <param name="cantidad"></param>
        private static void SwitchActualizarStock(string material, double cantidad)
        {
            switch (material)
            {
                case "Acero":
                    Stock.CantAcero += cantidad;
                    break;
                case "Aluminio":
                    Stock.CantAluminio += cantidad;
                    break;
                case "Titanio":
                    Stock.CantTitanio += cantidad;
                    break;
                case "Fibra de Carbono":
                    Stock.CantCarbono += cantidad;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Actualiza el Stock en la clase estática Stock y luego actualiza los datos en la DB
        /// </summary>
        /// <param name="material1"></param>
        /// <param name="material2"></param>
        /// <param name="cantidad1"></param>
        /// <param name="cantidad2"></param>
        private static void ActualizarStock(string material1, string material2, double cantidad1, double cantidad2)
        {
            if (material1 != "") SwitchActualizarStock(material1, cantidad1);
            if (material2 != "") SwitchActualizarStock(material2, cantidad2);
            Stock.UpdateStock();
        }
        /// <summary>
        /// Agrega una orden al ListOrden, si no hay stock, lanza una excepción. Actualiza el stock en la DB y guarda la orden en la DB
        /// </summary>
        /// <param name="orden"></param>
        public static void AgregarOrden(Orden.Orden orden)
        {
            string materialMB = "";
            string materialP = "";
            double cantidadMaterialMB = 0;
            double cantidadMaterialP = 0;
            if (orden.BicicletaMB != null)
            {
                materialMB = orden.BicicletaMB.MaterialNecesario();
                cantidadMaterialMB = orden.BicicletaMB.CantMaterialNecesario() * orden.CantidadMB;
                if (!HaySuficienteMaterial(cantidadMaterialMB, materialMB)) 
                    throw new StockInsuficienteException("No hay suficiente " + materialMB + " en stock para fabricar Mountain Bike. Por favor, agregue más.");
            }
            if (orden.BicicletaP != null)
            {
                materialP = orden.BicicletaP.MaterialNecesario();
                cantidadMaterialP = orden.BicicletaP.CantMaterialNecesario() * orden.CantidadP;
                if (!HaySuficienteMaterial(cantidadMaterialP, materialP)) 
                    throw new StockInsuficienteException("No hay suficiente " + materialP + " en stock para fabricar Bicicleta Playera. Por favor, agregue más.");
            }
            ActualizarStock(materialMB, materialP, -cantidadMaterialMB, -cantidadMaterialP);
            listadoOrdenes.AgregarOrden(orden);
        }
        /// <summary>
        /// Vacía el ListOrden (lo iguala a null)
        /// </summary>
        public static void LimpiarOrdenes()
        {
            listadoOrdenes.ListadoOrdenes = new List<Orden.Orden>();
        }
        /// <summary>
        /// Imprime las ordenes en archivos de texto
        /// </summary>
        /// <param name="path"></param>
        public static void ImprimirArchivos(string path)
        {
            listadoOrdenes.ImprimirArchivos(path);
        }
    }
}
