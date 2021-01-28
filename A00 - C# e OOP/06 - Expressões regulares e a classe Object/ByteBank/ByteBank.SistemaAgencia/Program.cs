using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            ContaCorrente viriato = new ContaCorrente(521, 65892);
            Console.WriteLine(viriato);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "456.321.789-54";
            carlos_1.Profissao = "Motorista";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "456.321.789-54";
            carlos_2.Profissao = "Motorista";

            ContaCorrente contaTeste = new ContaCorrente(654, 85214);

            if (carlos_1.Equals(contaTeste))
            {
                Console.WriteLine("São iguais.");
            }
            else
            {
                Console.WriteLine("Não são iguais.");
            }




            Console.ReadLine();




            // Olá, mi nombre es Juarez e mi numero es 99699-6699

            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // string padrao = "[0-9]{4,5}[-][0-9]{4}";
            // string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            string textoDeTeste = "Olá, mi nombre es Juarez e mi numero es 99699-6699";

            Match resultado = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultado.Value);




            Console.ReadLine();

            // ----------------------------------------


            string urlTeste = "http://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("http://www.bytebank.com");

            Console.WriteLine(indiceByteBank == 0);

            Console.WriteLine(urlTeste.StartsWith("http://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("http://www.bytebank.com"));

            Console.ReadLine();



            //string mensagemOrigem = "PALAVRA";
            //string termoBusca = "ra";

            //Console.WriteLine(termoBusca.ToUpper());


            //termoBusca = termoBusca.Replace("r", "R");
            //Console.WriteLine(termoBusca);

            //termoBusca = termoBusca.Replace("a", "A");
            //Console.WriteLine(termoBusca);

            //Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            //Console.ReadLine();





            string urlParametros = "http://www.bytebank.com.br/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentoURL extratorDeValores = new ExtratorValorDeArgumentoURL(urlParametros);


            Console.WriteLine(extratorDeValores);

            string valorOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de MoedaOrigem: " + valorOrigem);

            string valorDestino = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de MoedaDestino: " + valorDestino);

            string valorMoney = extratorDeValores.GetValor("VALor");
            Console.WriteLine("Valor do dinheiro: " + valorMoney);

            //string testeRemocao = "primeiraParte&parteParaRemover";
            //int indiceEComercial = testeRemocao.IndexOf("&");
            //Console.WriteLine(testeRemocao.Remove(indiceEComercial));

            Console.ReadLine();



            //--------------------------------------



            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da String: " + nomeArgumento.Length);

            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();



            // ---------------------------------



            string macaco = "";
            string jiboia = null;
            string coruja = "coruja";

            Console.WriteLine(string.IsNullOrEmpty(macaco));
            Console.WriteLine(String.IsNullOrEmpty(jiboia));
            Console.WriteLine(string.IsNullOrEmpty(coruja));
            Console.ReadLine();



            // ---------------------------------



            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf("?");
            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumento = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumento);





            Console.WriteLine("\n\n[Fim da execução]");
            Console.ReadLine();
        }
    }
}
