using System;

namespace _02_CriandoVariaveis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 02: Criando variáveis");
            int idade;
            idade = 33;

            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.Write(idade + "\n");

            idade = (10 + 5) * 2;
            Console.Write("Sua idade é " + idade + ".\n");

            Console.WriteLine("Execução finalizada. Tecle Enter para sair...");
            Console.ReadLine();
        }
    }
}