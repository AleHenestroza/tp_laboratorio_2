using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Entidades.DAO.Datos;

namespace Entidades.Datos
{
    public static class Stock
    {
        private static double cantAcero;
        private static double cantAluminio;
        private static double cantTitanio;
        private static double cantCarbono;
        private static StockDAO stockDAO;

        static Stock() 
        {
            GetStock();
        }

        private static void GetStock() 
        {
            stockDAO = new StockDAO();
            Dictionary<string, string> valores = stockDAO.SelectStock();
            if (!double.TryParse(valores["Acero"], out cantAcero)
                || !double.TryParse(valores["Aluminio"], out cantAluminio)
                || !double.TryParse(valores["Titanio"], out cantTitanio)
                || !double.TryParse(valores["Fibra de Carbono"], out cantCarbono)
                )
            {
                throw new Exception("Error al obtener datos de la base.");
            }
        }

        public static void UpdateStock()
        {
            Thread hiloUpdate = new Thread(EnviarDatosADB);
            hiloUpdate.Start();
        }

        private static void EnviarDatosADB()
        {
            stockDAO = new StockDAO();
            Dictionary<string, double> valores = new Dictionary<string, double>();
            valores.Add("Acero", cantAcero);
            valores.Add("Aluminio", cantAluminio);
            valores.Add("Titanio", cantTitanio);
            valores.Add("Fibra de Carbono", cantCarbono);
            stockDAO.UpdateStock(valores);
            stockDAO = null;
        }

        public static double CantAcero { get => cantAcero; set => cantAcero = value; }
        public static double CantAluminio { get => cantAluminio; set => cantAluminio = value; }
        public static double CantTitanio { get => cantTitanio; set => cantTitanio = value; }
        public static double CantCarbono { get => cantCarbono; set => cantCarbono = value; }
    }
}
