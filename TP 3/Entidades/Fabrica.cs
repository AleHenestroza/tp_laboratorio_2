using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Fabrica
    {
        private static List<Orden> listadoOrdenes;
        private static double stockAcero;
        private static double stockAluminio;
        private static double stockTitanio;
        private static double stockFibraCarbono;
        private static StreamWriter sw;

        static Fabrica()
        {
            listadoOrdenes = new List<Orden>();
            stockAcero = 0;
            stockAluminio = 0;
            stockTitanio = 0;
            stockFibraCarbono = 0;
        }

        public static List<Orden> ListadoOrdenes
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

        public static void AgregarOrden(Orden orden)
        {
            listadoOrdenes.Add(orden);
        }

        public static void ImprimirArchivos()
        {
            for (int i = 0; i < listadoOrdenes.Count; i++)
            {
                // CurrentDirectory retorna la ruta a {proyecto}\bin\debug\ donde {proyecto}
                // es el proyecto que esté llamando a la función.
                // De esa forma, debemos retroceder una vez para estar en \bin, otra vez para
                // quedar en la ruta del proyecto y una última vez para quedar en la ruta de
                // la solución.
                string path = Environment.CurrentDirectory + "\\..\\..\\..\\Ordenes\\";
                sw = new StreamWriter(path + (i+1) + ". Orden.txt");
                sw.Write(listadoOrdenes[i].ToString());
                sw.Close();
            }
        }

    }
}
