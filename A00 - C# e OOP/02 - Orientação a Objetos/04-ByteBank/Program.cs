using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();
            contaBruno.titular = "Bruno";

            Console.WriteLine("Conta Bruno: " + contaBruno.saldo);

            bool resultadoSaque = contaBruno.Sacar(300);
            Console.WriteLine("Conta Bruno: " + contaBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaBruno.Depositar(500);
            Console.WriteLine("Conta Bruno: " + contaBruno.saldo);

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";

            bool resultadoTransferencia = contaBruno.Transferir(77, contaGabriela);
            Console.WriteLine("Conta Bruno: " + contaBruno.saldo);
            Console.WriteLine("Conta Gabriela: " + contaGabriela.saldo);

            double assalto = (contaBruno.saldo = 0);
            Console.WriteLine("Conta Bruno: " + contaBruno.saldo);

            contaBruno.saldo = assalto;
            Console.WriteLine("Conta Bruno: " + contaBruno.saldo);

            Console.WriteLine("===========================");


            contaBruno.saldo += 500;
            Console.WriteLine("Conta Bruno: " + contaBruno.saldo);
            Console.WriteLine(assalto);
            Console.WriteLine("Conta Bruno: " + contaBruno.saldo);




            Console.ReadLine();
        }
    }

}
