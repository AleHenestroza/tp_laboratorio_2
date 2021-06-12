using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Productos;
using Entidades.Productos.Materiales;
using Entidades.Productos.Componentes;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Rueda r1 = new Rueda(26);
            Orden o = new Orden(new DateTime(2021, 12, 25));
            Orden o2 = new Orden(new DateTime(2021, 12, 25));
            o.OrdenarAccesorios(5, 3, 22, "rojo");
            o.OrdenarBicicletasMountainBike<FibraCarbono>(3, r1, r1, 38, false);
            o.OrdenarBicicletasPlayeras<Acero>(2, r1, r1, 32, true);
            o2.OrdenarAccesorios(2, 1, 24, "azul");
            o2.OrdenarBicicletasMountainBike<Titanio>(3, r1, r1, 38, false);
            o2.OrdenarBicicletasPlayeras<Aluminio>(2, r1, r1, 32, true);
            /*
             * Metodos inaccesibles por su nivel de visibilidad
             * o.OrdenarMountainBike<Acero>(r1, r1, 40, true);
             * o.OrdenarMountainBike<Titanio>(r1, r1, 40, false);
             * o.OrdenarPlayera<Acero>(r1, r1, 28, true);
             * o.OrdenarPlayera<FibraCarbono>(r1, r1, 28, false);
            */

            /*
             * Comprobar estado de la orden por consola
             * Console.WriteLine("ACCESORIOS");
             * Console.WriteLine(o.Accesorios);
             * Console.WriteLine("---------------------------------------------------");
             * Console.WriteLine("BICICLETAS");
             * Console.WriteLine(o.Bicicletas);
             * Console.WriteLine("---------------------------------------------------");
             * Console.WriteLine("COSTO DE LA ORDEN");
             * Console.WriteLine("$" + o.Costo);
            */
            Fabrica.AgregarOrden(o);
            Fabrica.AgregarOrden(o2);

            Console.WriteLine(Fabrica.ListadoOrdenes.ListadoOrdenes.Count);

            Fabrica.ExportarBinario();
            Fabrica.LimpiarOrdenes();
            Console.WriteLine(Fabrica.ListadoOrdenes.ListadoOrdenes.Count);

            string path = Environment.CurrentDirectory + "\\..\\..\\..\\Ordenes\\ordenes.bin";
            Fabrica.ImportarBinario(path);
            Console.WriteLine(Fabrica.ListadoOrdenes.ListadoOrdenes.Count);

            Fabrica.ImprimirArchivos();

            Console.ReadKey();
        }
    }
}
