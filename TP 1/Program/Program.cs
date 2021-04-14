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
            Console.WriteLine(binario);
            string binario2 = n1.BinarioDecimal("100a");
            Console.WriteLine(binario2);
            Console.ReadKey();
        }
    }
}
