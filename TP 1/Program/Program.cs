using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero n1 = new Numero();
            string binario = n1.BinarioDecimal("1010");
            string decimal1 = n1.DecimalBinario("10");
            string decimal2 = n1.DecimalBinario(4);
            Console.WriteLine(binario);
            string binario2 = n1.BinarioDecimal("100a");
            Console.WriteLine(binario2);
            Console.WriteLine(decimal1);
            Console.WriteLine(decimal2);
            Console.ReadKey();
        }
    }
}
