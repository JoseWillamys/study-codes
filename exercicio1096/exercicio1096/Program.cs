using System;

namespace exercicio1096 { 
    class Program { 
        static void Main(string[] args) {

            // Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

            for (int i = 1; i < 10; i++)
            {
                if (i % 2 != 0) {
                    Console.WriteLine("I=" + i + " J=7");
                    Console.WriteLine("I=" + i + " J=6");
                    Console.WriteLine("I=" + i + " J=5");
                }
            }
        }
    }
}