using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT02ex02
{
    internal class FT02
    {
        static void Main(string[] args)
        {
            

            string x = "Frase da letra X";
            string y = "Frase da letra Y";

            string CaracterX = x.Substring(0, 1);

          

            Console.WriteLine("\n\tPrimeiro caractere da primeira variável “x”: " + x.Substring(0, 1));
            Console.WriteLine("\tÚltimo caractere da variável 'y': " + y.Substring(y.Length - 1, 1));
            Console.WriteLine("\tTodos menos o primeiro caracter da variável 'x':" + x.Substring(1));
            Console.WriteLine("\tO terceiro elemento 'x':" + x.Substring(3, 1));
            Console.WriteLine("\tOs três primeiros elementos da variável 'y':" + y.Substring(0, 3));
            Console.WriteLine("\tOs três últimos elementos de 'y':" + y.Substring(y.Length - 3, 3));
            Console.ReadKey(); 
            
            //Pausa a execução sem fechar direto

            //Console.WriteLine("Escreva sua frase (x): " x.Substring();
            // x =  Console.ReadLine();
            //Console.WriteLine("\nEscreva a segunda frase (y): ");
            //y = Console.ReadLine(); 




        }
    }
}
