using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo");
            Console.WriteLine("========= \n \n");

            try
            {
                ContaCorrente conta = new ContaCorrente(500, 5030);
                Console.WriteLine(conta.Saldo);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(15);
                Console.WriteLine(conta.Saldo);

                ContaCorrente conta2 = new ContaCorrente(400, 65433);
                conta2.Transferir(1000, conta);
                Console.WriteLine("Saldo da Conta 1: " + conta.Saldo);
                Console.WriteLine("Saldo da Conta 2: " + conta2.Saldo);


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Nome do Cagão: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo Argument");
                Console.WriteLine(ex.Message);
            }

            catch (SaldoInsuficienteException exe)
            {
                Console.WriteLine("Saldo: " + exe.Saldo);
                Console.WriteLine("Tentativa: " + exe.ValorSaque);
                Console.WriteLine("StackTrace SaldoInsuficiente: " + exe.StackTrace);



                Console.WriteLine(exe.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficiente.");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("\n \n ========= \n \n");


            try
            {
                Metodo();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Tentativa de divisão por zero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Aconteceu um erro!");
            }


            Console.WriteLine("\n \n ========= \n \n");


            try
            {
                ContaCorrente conta01 = new ContaCorrente(231, 14568);
                ContaCorrente conta02 = new ContaCorrente(987, 45123);

                Console.WriteLine("Saldo " + nameof(conta01) + " : " + conta01.Saldo);
                Console.WriteLine("Saldo " + nameof(conta02) + " : " + conta02.Saldo);

                // conta01.Transferir(25, conta02);
                conta01.Sacar(190);
                Console.WriteLine("Saldo " + nameof(conta01) + " : " + conta01.Saldo);


            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("\n \nInformação sobre a INNER EXCEPTION:");
                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.InnerException.StackTrace);

            }


            Console.WriteLine("\n \n ========= \n \n");

            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("Catch no método MAIN");
            }

            Console.WriteLine("\nExecução finalizada.\nBom dia.");
            Console.ReadLine();
        }



        private static void CarregarContas()
        {
            
            
            
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("texte.txt"))
            {
                // IDisposable é uma interface
                leitor.LerProximaLinha();
            }




            //-----------------------------------------------------

            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException)
            //{

            //    Console.WriteLine("Exceção do tipo IOExpection capturada e tratada.");
            //}
            //finally
            //{
            //    Console.WriteLine("[Executando o Finally]");
            //    if (leitor != null) leitor.Fechar();
            //}


        }



        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(2);
        }





        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }





        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com o número [" + numero + "] e divisor [" + divisor + "].");
                throw;
                Console.WriteLine("Codigo ignorado");
            }
        }





    }
}
