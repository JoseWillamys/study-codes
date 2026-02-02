using System;

namespace exercicio1073 { 
    class Program { 
        static void Main(string[] args) {
            // Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares,
            // de 1 até N, inclusive N, se for o caso.

            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) { 
                if (i % 2 == 0) { 
                    Console.WriteLine(i + "^2 = " + Math.Pow(i, 2));
                }
            }
        }
    }
}