using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021, 05, 21);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromDays(365); //dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca, 2, System.Globalization.CultureInfo.GetCultureInfo("fr")) + ".";

            

            // string mensagem = "Vencimento em " + GetIntervaloDeTempoLegivelOld(diferenca);

           

            Console.WriteLine("Data Limite: " + dataFimPagamento);
            Console.WriteLine("Data atual: " + dataCorrente);
            Console.WriteLine(mensagem);




            Console.WriteLine("\n\n[Fim da execução]");
            Console.ReadLine();
        }









        static string GetIntervaloDeTempoLegivelOld(TimeSpan timespan)
        {
            Console.WriteLine("Inicializando Método");
            if (timespan.Days > 30)
            {
                Console.WriteLine("Inicializando if 01");
                int quantidadeMeses = timespan.Days / 30;

                if (quantidadeMeses == 1)
                {
                    Console.WriteLine("Inicializando if 02");
                    return "1 mês";
                }
                return quantidadeMeses + " meses";
            }
            else if (timespan.Days > 7)
            {

            }
            return timespan.Days + " dias";
        }
    }
}
