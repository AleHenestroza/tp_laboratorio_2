using System;
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
            o.OrdenarAccesorios(5, 3, 22, "rojo");
            o.OrdenarBicicletasMountainBike<FibraCarbono>(3, r1, r1, 38, false);
            o.OrdenarBicicletasPlayeras<Acero>(2, r1, r1, 32, true);
            /*
            o.OrdenarMountainBike<Acero>(r1, r1, 40, true);
            o.OrdenarMountainBike<Titanio>(r1, r1, 40, false);
            o.OrdenarPlayera<Acero>(r1, r1, 28, true);
            o.OrdenarPlayera<FibraCarbono>(r1, r1, 28, false);
            */
            /*
            Console.WriteLine("ACCESORIOS");
            Console.WriteLine(o.Accesorios);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("BICICLETAS");
            Console.WriteLine(o.Bicicletas);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("COSTO DE LA ORDEN");
            Console.WriteLine("$" + o.Costo);
            */

            Fabrica.AgregarOrden(o);
            Fabrica.ImprimirArchivos();

            //Console.ReadKey();
        }
    }
}
