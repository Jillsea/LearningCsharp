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

        static void LidandoComFileStream()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024]; //1kb
                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                    Console.WriteLine($"\n\nBytes lidos: {numeroDeBytesLidos}\n\n");


                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }

            }


            Console.ReadLine();
        }



        static void EscreverBuffer(byte[] material, int bytesLidos)
        {

            var utf8 = Encoding.UTF8;
            // var texto = Encoding.UTF8.GetString(material);
            var texto = utf8.GetString(material, 0, bytesLidos);
            Console.Write(texto);

            //foreach (var meuByte in material)
            //{
            //    Console.Write(texto);
            //    Console.Write(" ");
            //}
        }
    }
}

