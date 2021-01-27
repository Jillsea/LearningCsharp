using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 867498541);
            Console.WriteLine("Total de Contas: " + ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.NumeroCC);

            ContaCorrente contaGabriela = new ContaCorrente(867, 86745820);

            Console.ReadLine();
        }
    }
}
