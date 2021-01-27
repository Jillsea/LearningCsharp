using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Calculapoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;
            int meses = 12;
                       
            Console.WriteLine("Executando projeto 11:");

            for (int i = 0; i < meses; i++)
            {
                // 0.36% = 0.0036
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + i + " mês você terá R$" + valorInvestido);

            }


            Console.ReadLine();
        }
    }
}
