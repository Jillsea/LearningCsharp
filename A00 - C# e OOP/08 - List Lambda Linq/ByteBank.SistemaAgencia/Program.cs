using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD

            // One day I ll remember all this mess and laugh

=======
>>>>>>> main
            ListaGenerica<int> idades = new ListaGenerica<int>();
            idades.Adicionar(5);
            idades.AdicionarVarios(84, 15, 21, 17, 20);

<<<<<<< HEAD
            int idadeSoma = 0;
=======
>>>>>>> main
            for (int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
            }

            Console.ReadLine();
        }

        static void primeiraAula()
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

        static void segundaAula()
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

        static void terceiraAula()
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

        static void quartaAula()
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

        static void quintaAula()
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

    }
}
