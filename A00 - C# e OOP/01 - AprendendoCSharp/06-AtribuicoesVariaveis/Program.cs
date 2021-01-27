using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_AtribuicoesVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 06: Atribuições de Variáveis");

            int idade = 32;
            int idadeGustavo = idade;
            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);



            Console.ReadLine();
        }
    }
}
