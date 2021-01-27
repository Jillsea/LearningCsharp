using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando Diretor: " + Nome);
        }



        public override void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.1);
            // Salario = Salario * 1.1;
            // Salario *= 1.1;

            MensagensSalario(1.15);
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
