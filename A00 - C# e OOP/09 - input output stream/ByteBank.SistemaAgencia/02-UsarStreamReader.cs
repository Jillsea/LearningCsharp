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
        static void UsarStreamReader()
        {

            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();

                    var contaCorrente = ConverterStringParaCC(linha);

                    // Console.WriteLine(linha);

                    var msg = $"{contaCorrente.Titular.Nome}: Ag. {contaCorrente.Agencia}, CC. {contaCorrente.Numero}, Saldo total: {contaCorrente.Saldo}.";
                    Console.WriteLine(msg);
                }
            }
        }

        static ContaCorrente ConverterStringParaCC(string linha)
        {
            string[] campos = linha.Split(',');

            var agencia = campos[0];
            var numeroCC = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var agenciaInt = int.Parse(agencia);
            var numeroCCInt = int.Parse(numeroCC);
            var saldoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;


            var resultado = new ContaCorrente(agenciaInt, numeroCCInt);
            resultado.Depositar(saldoDouble);
            resultado.Titular = titular;

            return resultado;

        }










    }
}
