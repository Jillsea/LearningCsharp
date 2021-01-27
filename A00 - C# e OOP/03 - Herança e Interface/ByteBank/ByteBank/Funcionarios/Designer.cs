using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Criando Designer: " + Nome);
        }

        public override void AumentarSalario()
        {
            Console.WriteLine("Antigo salario: " + Salario);
            Salario *= 1.11;
            Console.WriteLine("Novo salario: " + Salario);
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
