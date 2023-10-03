using System;

    namespace FT01
{
     internal class Programa01
    {
        static void Main (string[] args)
        {
            string nomeA, nomeE, nomeD;
            Console.WriteLine("Insira seu nome e seu apelido: ");
            nomeA = Console.ReadLine();
            Console.WriteLine("\nInsira o nome da sua escola: ");
            nomeE = Console.ReadLine();
            Console.WriteLine("\nInsira o nome da sua disciplina: ");
            nomeD = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n\nNome do aluno: {0}\n\n", nomeA);
            Console.WriteLine("\nNome da escola: {0}\n\n", nomeE);
            Console.WriteLine("\nNome da disciplina: {0}\n\n", nomeD);

        }
    }
}
