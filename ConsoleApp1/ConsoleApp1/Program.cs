using System;


namespace ConsoleApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;
            Console.WriteLine("Insira o primeiro numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            soma =  n1 + n2;
            Console.WriteLine("A soma do numero {0} e do numero {1} é {2}", n1, n2, soma);

        }
    }
}