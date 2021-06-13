using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase estática Fabrica contiene un listado de ordenes.
    /// Es consumida por los formularios de la aplicación para generar nuevas
    /// ordenes, guardar las ordenes a archivos, exportar el listado a binario
    /// o importar un listado desde un archivo binario.
    /// </summary>
    public static class Fabrica
    {
        private static ListOrdenSerializable listadoOrdenes;
        private static double stockAcero;
        private static double stockAluminio;
        private static double stockTitanio;
        private static double stockFibraCarbono;

        static Fabrica()
        {
            stockAcero = 0;
            stockAluminio = 0;
            stockTitanio = 0;
            stockFibraCarbono = 0;
            listadoOrdenes = new ListOrdenSerializable();
        }

        public static ListOrdenSerializable ListadoOrdenes
        {
            get
            {
                return listadoOrdenes;
            }
        }
        public static double StockAcero
        {
            get
            {
                return stockAcero;
            }
        }
        public static double StockAluminio
        {
            get
            {
                return stockAluminio;
            }
        }
        public static double StockTitanio
        {
            get
            {
                return stockTitanio;
            }
        }
        public static double StockFibraCarbono
        {
            get
            {
                return stockFibraCarbono;
            }
        }
        public static int CantidadOrdenes
        {
            get
            {
                return ListadoOrdenes.ListadoOrdenes.Count;
            }
        }

        public static void ModificarStockMateriales(double cantAcero,
                                                    double cantAluminio,
                                                    double cantTitanio, 
                                                    double cantFibraCarbono)
        {
            stockAcero += cantAcero;
            stockAluminio += cantAluminio;
            stockTitanio += cantTitanio;
            stockFibraCarbono += cantFibraCarbono;
        }

        public static void ModificarStockMaterial(double cantidad, string material)
        {
            switch (material)
            {
                case "Acero":
                    stockAcero += cantidad;
                    break;
                case "Aluminio":
                    stockAluminio += cantidad;
                    break;
                case "Titanio":
                    stockTitanio += cantidad;
                    break;
                case "Fibra de Carbono":
                    stockFibraCarbono += cantidad;
                    break;
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
            listadoOrdenes = (ListOrdenSerializable)ser.Deserialize(fs);
            fs.Close();

        }

        public static void AgregarOrden(Orden orden)
        {
            listadoOrdenes.AgregarOrden(orden);
        }

        public static void LimpiarOrdenes()
        {
            listadoOrdenes.ListadoOrdenes = new List<Orden>();
        }

        public static void ImprimirArchivos()
        {
            listadoOrdenes.ImprimirArchivos();
        }

    }
}
