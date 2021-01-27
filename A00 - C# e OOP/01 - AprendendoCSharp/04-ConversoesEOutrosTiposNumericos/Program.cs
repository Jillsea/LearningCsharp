using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 04:");

            double salario = 1200.50;
            Console.WriteLine(salario);

            // O int é um tipo de variável de 32 bits
            int SalarioEmInteiro = (int)salario;
            Console.WriteLine(SalarioEmInteiro);

            // O long é um tipo de variável de 64 bits
            long idade = 13000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variável de 16 bits
            short produtos = 15000;
            Console.WriteLine(produtos);

            float altura = 1.80f;
            Console.WriteLine(altura);






            Console.ReadLine();
        }
    }
}
