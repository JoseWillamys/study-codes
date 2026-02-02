using System;

namespace exercicio1075 { 
    class Program { 
        static void Main(string[] args) {

            // Leia um valor inteiro N. Apresente todos os números entre
            // 1 e 10000 que divididos por N dão resto igual a 2.

            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++) { 
                if ( i % n == 2) { 
                    Console.WriteLine(i);
                }
            }
        }
    }
}