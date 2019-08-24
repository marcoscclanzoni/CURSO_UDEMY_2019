using System;

namespace Saida_dados_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.873487;
            string nome = "Maria";
            // Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais ", nome, idade, saldo);
            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo de {saldo:F2} reais");
            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo de " + saldo.ToString("F2") + " reais ");


        }
    }
}
