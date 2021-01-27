using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numeroCC = 863452;



            ContaCorrente contaGabrielaCosta = new ContaCorrente();
            contaGabrielaCosta.titular = "Gabriela";
            contaGabrielaCosta.agencia = 863;
            contaGabrielaCosta.numeroCC = 863452;

            Console.WriteLine("Igualdade de tipo referencia: " + (contaGabriela == contaGabrielaCosta));



            int idade = 27;
            int dinheiro = 27;
            Console.WriteLine("Igualdade de tipo valor: " + (idade == dinheiro));

            contaGabriela = contaGabrielaCosta;
            Console.WriteLine("Igualdade de tipo referencia: " + (contaGabriela == contaGabrielaCosta));

            contaGabriela.saldo = 777;
            Console.WriteLine(contaGabriela.saldo);
            Console.WriteLine(contaGabrielaCosta.saldo);

            Console.WriteLine("Igualdade de tipo referencia: " + (contaGabriela == contaGabrielaCosta));


            if (contaGabriela.saldo >= 100)
            {
                contaGabriela.saldo -= 100;
            }


            Console.ReadLine();
        }
    }
}
