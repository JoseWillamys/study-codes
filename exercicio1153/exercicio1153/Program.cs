using System;

namespace exercicio1153 { 
    class Program { 
        static void Main(string[] args) {

            // Ler um valor N. Calcular e escrever seu respectivo fatorial.
            // Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.

            int n, fatorial;

            n = int.Parse(Console.ReadLine());
            fatorial = n;

            for (int i = n - 1; i > 0; i--) {
                fatorial *= i;
            }

            Console.WriteLine(fatorial);
        }
    }
}