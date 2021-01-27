using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IRvalido = false;
            double salario = 4000.0;
            double IR = 0;
            int deducao = 0;

            if (salario > 1900 && salario < 4664.01)
            {
                IRvalido = true;
            }

            if (IRvalido == true)
            {
                if (salario >= 1900.0 && salario <= 2800.0)
                {
                    IR = 7.5;
                    deducao = 142;
                }
                else if (salario >= 2800.01 && salario <= 3751.0)
                {
                    IR = 15;
                    deducao = 350;
                }
                else if (salario >= 3751.01 && salario <= 4664.00)
                {
                    IR = 22.5;
                    deducao = 636;
                }      
                Console.WriteLine("Para o valor " + salario + " o IR é de " + IR + "%, neste valor você pode deduzir até R$" + deducao + ".");
            }
            else
            {
                if (salario < 1900.00)
                {
                    Console.WriteLine("O valor do salário esta abaixo do mínimo válido para o IR.");
                }
                else
                {
                    Console.WriteLine("É muito dinheiro, não sabemos calcular.");
                }
            }


            //De 1900.0 até 2800.0, o IR é de 7.5 % e pode deduzir na declaração o valor de R$ 142;
            //De 2800.01 até 3751.0, o IR é de 15 % e pode deduzir R$ 350;
            //De 3751.01 até 4664.00, o IR é de 22.5 % e pode deduzir R$ 636.
            Console.ReadLine();
        }
    }
}
