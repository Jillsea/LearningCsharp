using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Mecanica";
            //gabriela.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = gabriela;
            //conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.profissao = "Mecanica";
            conta.titular.cpf = "434.562.878-20";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numeroCC = 5634527;


            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.profissao);
            Console.WriteLine(conta.titular.cpf);

            Console.ReadLine();
        }
    }
}
