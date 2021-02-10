using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensões;
using System.IO;

namespace ByteBank.SistemaAgencia
{
    partial class Program
    {
       
        static void PrimeiraAula()
        {
            // Array de inteiros com 5 posições

            int[] idades = null;
            idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            // idades[4] = 27;

            int indice = 4;
            int novaIdade = idades[indice];
            Console.WriteLine($"Valor da array: {novaIdade}");

            int[] outroArray = idades;
            Console.WriteLine($"Array clonada: {outroArray[1]}");

            bool[] arrayDeBooleanos = new bool[10];

            arrayDeBooleanos[0] = true;
            arrayDeBooleanos[1] = false;
            arrayDeBooleanos[2] = false;
            arrayDeBooleanos[3] = true;

            Console.ReadLine();
        }

        static void SegundaAula()
        {
            // Array de inteiros com 5 posições

            int[] idades = null;
            idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 27;


            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando a posição [{indice}] com o valor: {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"tamanho do array: [{idades.Length}]");
        }

        static void TerceiraAula()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
            new ContaCorrente(987, 85637),
            new ContaCorrente(777, 88888),
            new ContaCorrente(123, 12345)
            };



            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta no indice [{indice}]: Agencia {contas[indice].Agencia}");

            }


        }

        static void QuartaAula()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoJillsea = new ContaCorrente(777, 99999);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                 contaDoJillsea,
                 new ContaCorrente(854, 77777),
                 new ContaCorrente(555, 65412),
                 new ContaCorrente(456, 12345),
                 new ContaCorrente(452, 12345),
                 new ContaCorrente(123, 12345),
                 new ContaCorrente(321, 12345),
                 new ContaCorrente(213, 12345),
                 new ContaCorrente(153, 12345),
                 new ContaCorrente(531, 12345),
                 new ContaCorrente(485, 12345),
                 new ContaCorrente(999, 12345),
                 new ContaCorrente(854, 12345),
                 new ContaCorrente(965, 12345)
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(contaDoJillsea,
                 new ContaCorrente(854, 77777),
                 new ContaCorrente(555, 65412),
                 new ContaCorrente(456, 12345),
                 new ContaCorrente(452, 12345),
                 new ContaCorrente(123, 12345),
                 new ContaCorrente(321, 12345),
                 new ContaCorrente(213, 12345),
                 new ContaCorrente(153, 12345),
                 new ContaCorrente(531, 12345),
                 new ContaCorrente(485, 12345),
                 new ContaCorrente(999, 12345),
                 new ContaCorrente(854, 12345),
                 new ContaCorrente(965, 12345));






            Console.WriteLine("\n\n\n");

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição [{i}] = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }


            Console.WriteLine($"\n\n\nArray de números: {SomarVarios(1, 2, 3, 4, 5)}");
            Console.WriteLine(SomarVarios(10, 10, 10, 10, 10));

            // lista.Remover(contaDoJillsea);
            // Console.WriteLine();
            // lista.EscreverListaNaTela();

            // alterando apenas o 2º valor opcional
            //lista.MeuMetodo(numero:20);

            Console.ReadLine();
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int valor in numeros)
            {
                acumulador += valor;
            }
            return acumulador;
        }

        static void QuintaAula()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(7);
            listaDeIdades.Adicionar(15);
            listaDeIdades.Adicionar("um texto");
            listaDeIdades.AdicionarVarios(16, 25, 54, 78, 32, 33, 20, 21);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice [{i}]: {idade}.");
            }


            Console.ReadLine();
        }

        static void SextaAula()
        {
            var conta = new ContaCorrente(457, 77451);
            conta.Depositar(77);

            var gerenciador = new GerenciadorBonificacao();
            var gerenciadores = new List<GerenciadorBonificacao>();

            var numero = 5;
            numero += 5;
            Console.WriteLine(numero);

            var resultado = SomarVarios(1, 2, 3, 4, 5);
            Console.WriteLine(resultado);

            Console.ReadLine();
        }

        static void SetimaAula()
        {
            var idades = new List<int>();
            idades.Add(5);

            // idades.AddRange(new int[] { 84, 15, 21, 17, 20 });
            // ListExtensoes.AddMany(idades, 21, 51, 32, 18, 37);
            idades.AddMany(21, 23, 65, 29, 24, 47);


            idades.AddMany(45, 54, 77, 98);



            for (int i = 0; i < idades.Count; i++)
            {
                int idadeAtual = idades[i];
                Console.WriteLine($"Posição [{i}]: {idadeAtual}");
            }

            idades.Remove(21);
            Console.WriteLine();

            for (int i = 0; i < idades.Count; i++)
            {
                int idadeAtual = idades[i];
                Console.WriteLine($"Posição [{i}]: {idadeAtual}");
            }

            Console.WriteLine();



            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                int idadeAtual = idades[i];
                Console.WriteLine($"Posição [{i}]: {idadeAtual}");
            }

            Console.WriteLine();





            List<string> nomes = new List<string>();
            nomes.Add("Giorno");

            // ListExtensoes.AddMany(nomes,"Joseph", "Jonathan", "Jotaro", "Josuke", "Jolyne", "Johnny");
            nomes.AddMany("Joseph", "Jonathan", "Jotaro", "Josuke", "Jolyne", "Johnny");

            for (int i = 0; i < nomes.Count; i++)
            {
                string nomeAtual = nomes[i];
                Console.WriteLine($"Posição [{i}]: {nomeAtual}");
            }

            Console.WriteLine();

            nomes.Sort();

            for (int i = 0; i < nomes.Count; i++)
            {
                string nomeAtual = nomes[i];
                Console.WriteLine($"Posição [{i}]: {nomeAtual}");
            }

            Console.WriteLine();



            string guilherme = "Guilherme";
            guilherme.TesteGenerico<int>();










            Console.ReadLine();
        }

        static void OitavaAula()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 68541),
                new ContaCorrente(741, 65432),
                new ContaCorrente(125, 44157),
                null,
                new ContaCorrente(987, 55468),
                new ContaCorrente(774, 74125),
                null,
                null,
                new ContaCorrente(456, 98787)
            };

            contas.Add(new ContaCorrente(777, 99999));

            // Usa a implementação do IComparable
            // contas.Sort();

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            // -----------------------------------------------

            // var listaSemNulos = new List<ContaCorrente>();

            // foreach (var conta in contas)
            // {
            //     if (conta!=null)
            //     {
            //         listaSemNulos.Add(conta);
            //     }
            // }

            // IEnumerable<ContaCorrente> contasNaoNulas =
            //     contas.Where(conta => conta != null);


            var contasReorganizadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Agencia);


            foreach (var organizado in contasReorganizadas)
            {
                Console.WriteLine($"Agencia: {organizado.Agencia}, CC:{organizado.Numero}.");
            }

            Console.WriteLine(int.MaxValue);
        }
    }
}
