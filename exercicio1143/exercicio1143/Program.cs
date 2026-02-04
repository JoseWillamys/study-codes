using System;

namespace exercicio1143 { 
    class Program { 
        static void Main(string[] args) {

            // Escreva um programa que leia um valor inteiro N (1 < N < 1000).
            // Este N é a quantidade de linhas de saída que serão apresentadas
            // na execução do programa.

            // O arquivo de entrada contém um número inteiro positivo N.


            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine(i + " " + Math.Pow(i, 2) + " " + Math.Pow(i, 3));
            }
        }
    }
}