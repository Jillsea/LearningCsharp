using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 05: Caracteres e Textos");

            //character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Curso de C# ";
            Console.WriteLine(titulo + 2020);

            string vazia = "";
            Console.WriteLine(vazia);

            string cursosProgramação =
@"
- .NET
- JAVA
- Javascript
- Assembly";
            Console.WriteLine(cursosProgramação);



            Console.ReadLine();
        }
    }
}
