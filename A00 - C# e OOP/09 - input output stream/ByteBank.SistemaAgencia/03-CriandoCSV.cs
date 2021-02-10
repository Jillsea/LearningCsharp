using System;
using System.IO;
using System.Text;

namespace ByteBank.SistemaAgencia
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "132,45687,777.00,John Doe";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);




                fluxoDeArquivo.Write(bytes,0,bytes.Length);
            }
        }


        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivos = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
                using (var escritor = new StreamWriter(fluxoDeArquivos))
            {
                escritor.Write("987,99999,500.00,Pedro de Lara");
            }
        }


        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for(int i = 0; i < 100; i++)
                {
                    escritor.WriteLine($"Linha: {i}");
                    escritor.Flush();

                    Console.WriteLine($"Linha: {i}");
                    Console.ReadLine();
                }
            }
        }





        // -------------------------------
    }
}