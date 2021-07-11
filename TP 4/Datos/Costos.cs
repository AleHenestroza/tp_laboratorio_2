using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DAO.Datos;

namespace Datos
{
    public static class Costos
    {
        private static double costoAcero;
        private static double costoAluminio;
        private static double costoTitanio;
        private static double costoCarbono;
        private static double costoRueda;
        private static double costoCasco;
        private static double costoLuz;
        private static CostosDAO costosDAO;

        static Costos()
        {
            GetCostos();
        }

        private static void GetCostos()
        {
            costosDAO = new CostosDAO();
            Dictionary<string, string> valores = costosDAO.SelectCostos();
            if (!double.TryParse(valores["Acero"], out costoAcero)
                || !double.TryParse(valores["Aluminio"], out costoAluminio)
                || !double.TryParse(valores["Titanio"], out costoTitanio)
                || !double.TryParse(valores["Fibra de Carbono"], out costoCarbono)
                || !double.TryParse(valores["Rueda"], out costoRueda)
                || !double.TryParse(valores["Casco"], out costoCasco)
                || !double.TryParse(valores["Luz"], out costoLuz)
                )
            {
                throw new Exception("Error al obtener datos de la base.");
            }
            costosDAO = null;
        }

        public static void UpdateCostos()
        {
            costosDAO = new CostosDAO();
            Dictionary<string, double> valores = new Dictionary<string, double>();
            valores.Add("Acero", costoAcero);
            valores.Add("Aluminio", costoAluminio);
            valores.Add("Titanio", costoTitanio);
            valores.Add("Fibra de Carbono", costoCarbono);
            valores.Add("Rueda", costoRueda);
            valores.Add("Casco", costoCasco);
            valores.Add("Luz", costoLuz);
            costosDAO.UpdateCostos(valores);
            costosDAO = null;
        }

        public static double CostoAcero { get => costoAcero; set => costoAcero = value; }
        public static double CostoAluminio { get => costoAluminio; set => costoAluminio = value; }
        public static double CostoTitanio { get => costoTitanio; set => costoTitanio = value; }
        public static double CostoCarbono { get => costoCarbono; set => costoCarbono = value; }
        public static double CostoRueda { get => costoRueda; set => costoRueda = value; }
        public static double CostoCasco { get => costoCasco; set => costoCasco = value; }
        public static double CostoLuz { get => costoLuz; set => costoLuz = value; }

    }
}
