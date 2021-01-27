using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(852,123852);

            conta.Sacar(12);

            Console.WriteLine(conta.Saldo);

            new ContaCorrente(555, 99685);

            Console.ReadLine();
        }
    }
}
