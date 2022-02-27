using System;
using Newtonsoft.Json;

namespace ConsoleApp2
{
    internal class Program
    {

        public class Pessoa
        {
            public string Nome { get; set; }
            public string Endereco { get; set; }
            public string Bairro { get; set; }
        }

        static void Main(string[] args)
        {
            string str = "{ \"Nome \": \"maria da silva\", \"Endereco \": \"Rua A \", \"Bairro \": \"Centro\"}";




            Console.WriteLine("***** Exemplo Convertendo uma string para JSON ****");
           
            dynamic json = JsonConvert.DeserializeObject(str);

            Console.WriteLine(json);



            //****************************// Exemplo converter para um objeto Pessoa //****************************************


            Console.WriteLine("***** Exemplo convertendo um json para OBJETO C# ****");
            string strobj = "{ \"Nome\": \"Pedro Scoby\", \"Endereco\": \"Rua Maraca\", \"Bairro\": \"Vila Guilhermina\"}";
            var p = JsonConvert.DeserializeObject<Pessoa>(strobj);
            Console.WriteLine(p.Nome  + ";" + p.Endereco + ";" + p.Bairro);
            Console.WriteLine();
            //****************************// Exemplo converter um objeto para JSON //****************************************

            Console.WriteLine("***** Exemplo convertendo um objeto C# para json ****");
            var ress = JsonConvert.SerializeObject(p);

            Console.WriteLine(ress);
            Console.ReadKey();

        }
    }
}
