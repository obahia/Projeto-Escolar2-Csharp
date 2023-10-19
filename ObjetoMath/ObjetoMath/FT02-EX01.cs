using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoMath
{
    internal class FT02EX01
    {
        static void Main(string[] args)
        {
           
        
            Console.WriteLine("\nNúmero (2) elevado ao quadrado: {0}", Math.Pow(2, 3));
            Console.WriteLine("\nNúmero arredondado (2.26): {0}", Math.Round(2.26d, 1));
            Console.WriteLine("\nValor de PI: {0}", Math.PI);
            Console.WriteLine("\nRaíz quadrada (64): {0}", Math.Sqrt(64d));
            Console.WriteLine("\nRetorne o menor valor (2.3): {0}", Math.Floor(2.3));
            Console.WriteLine("\nRetorne o maior valor (2.3): {0}", Math.Ceiling(2.3));
            Console.WriteLine("\nRetorne o valor minímo de dois números (10 e 20): {0}", Math.Min(10, 20));
            Console.WriteLine("\nRetorne o valor minímo de dois números (10 e 20): {0}", Math.Max(10, 20));





            Console.ReadKey();
         
            
        }
    }
}
