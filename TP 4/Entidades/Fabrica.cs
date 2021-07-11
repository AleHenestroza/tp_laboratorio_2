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
        public static void ExportarBinario()
        {
            string path = Environment.CurrentDirectory + "\\..\\..\\..\\Ordenes\\ordenes.bin";
            ExportarBinario(path);
        }
        public static void ExportarBinario(string path)
        {
            Stream fs;
            BinaryFormatter ser;

            fs = new FileStream(path, FileMode.Create);
            ser = new BinaryFormatter();
            ser.Serialize(fs, listadoOrdenes);
            fs.Close();
        }
        public static void ExportarBinario(Stream fs)
        {
            BinaryFormatter ser;

            ser = new BinaryFormatter();
            ser.Serialize(fs, listadoOrdenes);
            fs.Close();
        }
        public static void ImportarBinario(string path)
        {
            Stream fs;
            BinaryFormatter ser;

            fs = new FileStream(path, FileMode.Open);
            ser = new BinaryFormatter();
            listadoOrdenes = (ListOrden)ser.Deserialize(fs);
            fs.Close();

        }
        public static void ImportarOrdenesDB()
        {
            OrdenDAO ordenDAO = new OrdenDAO();
            ListadoOrdenes = ordenDAO.SelectOrdenes();
        }
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
        private static void ActualizarStock(string material1, string material2, double cantidad1, double cantidad2)
        {
            if (material1 != "") SwitchActualizarStock(material1, cantidad1);
            if (material2 != "") SwitchActualizarStock(material2, cantidad2);
            Stock.UpdateStock();
        }
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
        public static void LimpiarOrdenes()
        {
            listadoOrdenes.ListadoOrdenes = new List<Orden.Orden>();
        }
        public static void ImprimirArchivos()
        {
            listadoOrdenes.ImprimirArchivos();
        }
        public static void ImprimirArchivos(string path)
        {
            listadoOrdenes.ImprimirArchivos(path);
        }
    }
}
