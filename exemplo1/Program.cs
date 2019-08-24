using System;
using System.Globalization;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.Write("Olá mundo!"); // escreve texto Ola Mundo
            Console.WriteLine("Bom dia!"); // acima sem quebra de linha
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2")); // f2 deixa o numero com 2 casas apos o ponto
            Console.WriteLine(x.ToString("F4")); // f4 deixa o numero com 4 casas apos ponto
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); // aqui temos a troca do ponto por virgula

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            Console.ReadLine();
        }
    }
}