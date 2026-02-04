using System;

namespace exercicio1097
{
    class Program {
        static void Main(string[] args)  {

            // Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

            int j1, j2, j3;
            j1 = 7;
            j2 = 6;
            j3 = 5;

            for (int i = 1; i < 10; i++) {
                
                if (i % 2 != 0) {
                    Console.WriteLine("I=" + i + " J=" + j1);
                    Console.WriteLine("I=" + i + " J=" + j2);
                    Console.WriteLine("I=" + i + " J=" + j3);
                    j1 += 2;
                    j2 += 2;
                    j3 += 2;
                }
            }
        }
    }
}