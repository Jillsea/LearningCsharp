using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
     public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Criando Auxiliar: " + Nome);
        }

        public override void AumentarSalario()
        {
            Console.WriteLine("Antigo salario: " + Salario);
            Salario *= 1.10;
            Console.WriteLine("Novo salario: " + Salario);
        }

        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }
    }
}
