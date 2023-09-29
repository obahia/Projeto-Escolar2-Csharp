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
            Console.WriteLine("\n\nNome do aluno: \n\n", nomeA);
            Console.WriteLine("Nome da escola: \n\n", nomeE);
            Console.WriteLine("Nome da disciplina: {2}\n\n", nomeD);

        }
    }
}
