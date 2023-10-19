using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = {1, 2, 3, 4, 5, 6};
            foreach (int i in ints)
            
                Console.WriteLine(i);
                

            double[] reais = new double[5];
            reais[0] = 24d;
            reais[1] = 24.65d;
            reais[2] = 45.9d;
            reais[3] = 22d;
            reais[4] = 221.1d;
            foreach (double i in reais) 
            Console.WriteLine(i);
    

            string[] palavras = new string []{"abc", "def", "ghi", "jkl", "mno" };
            foreach (string i in palavras)
                Console.WriteLine(i);
               

            //Verificar se existe dentro da array
            Console.WriteLine(palavras.Contains("def"));
            
            //Tamanho da array
            Console.WriteLine(palavras.Length);
            

            //Declarar array multidimensional

            int[,] multInteiros = new int[,] { { 1, 2, 3, }, { 4, 60, 6 } };
            Console.WriteLine(multInteiros[1,1]);
            
            //Declarar arrays de arrays (jagged arrays)
            int[][] jInteiros = new int[3][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 } };
            Console.WriteLine(jInteiros[1][2]);
            Console.ReadKey();
            

        }
    }
}
