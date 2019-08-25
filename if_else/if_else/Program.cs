using System;
// esta logica testa se o numero é par ou impar
// data 24/08/2019
// autor marcos lanzoni

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um numero inteiro ........"); // faz a pergunta para entrar com numero inteiro
            int x = int.Parse(Console.ReadLine()); // grava o numero na variavel "x" 
            if (x % 2 == 0) // aqui verifica se o resto da divisão é igual a zero comprovando que é par
            {
                Console.WriteLine("O numero digitado é par "); // aqui informa que é  par
            }
            else {
                Console.WriteLine("O numero digitado é impar"); // caso o resto da divisão não seja zero é impar

            }

        }
    }
}
