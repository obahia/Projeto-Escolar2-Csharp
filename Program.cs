namespace FT01
{
    internal class Programa02
    {
        static void Main(string[] args)
        {
            int n1, n2, soma, mult, div, sub, media, rest_div;

            Console.WriteLine("Insira o primeiro numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInsira o segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

      
          
            Console.WriteLine("\n\nA soma: {0}", n1 + n2);
            Console.WriteLine("\nA multiplicacao: {0}", n1 * n2);
            Console.WriteLine("\nA divisao: {0}", n1 / n2);
            Console.WriteLine("\nA subtracao: {0}", n1 - n2);
            Console.WriteLine("\nA media: {0}", (n1 + n2) / 2);
            Console.WriteLine("\nO resto da divisao: {0}", n1 % n2);


        }
    }

}
