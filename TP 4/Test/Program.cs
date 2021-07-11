using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.DAO.Datos;
using Entidades.Orden;
using Entidades.Productos.Bicicletas;
using Entidades.Productos.Componentes;
using Entidades.Productos.Materiales;
using Entidades.Productos.Accesorios;
using Entidades.Datos;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Revisa si se recuperan correctamente los datos de la BBDD
            Console.WriteLine(Costos.CostoAcero);
            Console.WriteLine(Stock.CantAcero);
            StockDAO stockDAO = new StockDAO();
            Dictionary<string, string> data = stockDAO.SelectStock();
            foreach (KeyValuePair<string, string> asd in data)
            {
                Console.WriteLine(asd.Key);
                Console.WriteLine(asd.Value);
            }

            // Se revisa si se muestra correctamente el texto de una orden
            Casco casco = new Casco(57);
            Luz luz = new Luz("Amarillo");
            Bicicleta<Acero> mb = new MountainBike<Acero>(new Rueda(26), new Rueda(26), 58, false);
            Bicicleta<Aluminio> p = new Playera<Aluminio>(new Rueda(26), new Rueda(26), 58, true);

            Orden orden = new Orden(1, mb, 2, p, 1, casco, 3, luz, 5);

            Console.WriteLine(orden.MostrarOrden());

            Console.ReadKey();
        }
    }
}
