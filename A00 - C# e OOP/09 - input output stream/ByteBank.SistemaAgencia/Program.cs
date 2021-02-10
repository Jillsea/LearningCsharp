using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensões;
using System.IO;

namespace ByteBank.SistemaAgencia
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas);
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }


            Console.ReadLine();





            Console.WriteLine("Utilizando o WriteAllText...");
            File.WriteAllText("EscrevendoComAClasseFILE.txt", "Testando WriteAllText");


            Console.ReadLine();



            Console.WriteLine("Digite um nome:");
            var nome = Console.ReadLine();

            Console.WriteLine(nome);



            // CriarArquivoComWriter();
            // TestaEscrita();
            // LeituraBinaria();
            // UsarStreamDeEntrada();



            Console.ReadLine();
        }

      







    }
}
