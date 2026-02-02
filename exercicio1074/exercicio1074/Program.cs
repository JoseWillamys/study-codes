using System;

namespace exercicio1074 { 
    class Program { 
        static void Main(string[] args) {

            // Leia um valor inteiro N. Este valor será a quantidade de valores
            // que serão lidos em seguida. Para cada valor lido, mostre uma mensagem
            // em inglês dizendo se este valor lido é par (EVEN), ímpar (ODD),
            // positivo (POSITIVE) ou negativo (NEGATIVE). No caso do valor ser
            // igual a zero (0), embora a descrição correta seja (EVEN NULL),
            // pois por definição zero é par, seu programa deverá imprimir apenas NULL.

            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                int valor = int.Parse(Console.ReadLine());

                if (valor == 0) {
                    Console.WriteLine("NULL");
                }
                else if (valor % 2 == 0 && valor > 0) {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (valor % 2 == 0 && valor < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (valor % 2 != 0 && valor > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (valor % 2 != 0 && valor < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
        }
    }
}