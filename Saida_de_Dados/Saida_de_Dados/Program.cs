using System;
using System.Globalization;
namespace Saida_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 10.87823477;
            Console.WriteLine("Hello World!"); // com quebra de linha 
            Console.Write("Boa Tarde"); // sem quebra de linha
            Console.WriteLine("______________________________________________");
            Console.WriteLine(saldo);// imprime valor com todas as casas decimais
            Console.WriteLine(saldo.ToString("f2")); // aqui imprime somete 2 casas apos virgula
        }
    }
}
