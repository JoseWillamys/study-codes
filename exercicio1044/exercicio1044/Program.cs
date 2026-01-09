using System;

namespace exercicio1044
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leia 2 valores inteiros (A e B). Após, o programa deve mostrar
            // uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando
            // se os valores lidos são múltiplos entre si.

            string[] vet;
            int a, b;

            vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            if (b % a == 0 || a % b == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}