using System;

namespace exercicio1144 { 
    class Program {
        static void Main(string[] args) {

            // Escreva um programa que leia um valor inteiro N. N * 2 linhas de saída
            // serão apresentadas na execução do programa, seguindo a lógica do exemplo
            // abaixo. Para valores com mais de 6 dígitos, todos os dígitos devem ser
            // apresentados.

            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine(i + " " + i * i + " " + i * (i * i));
                Console.WriteLine(i + " " + (i * i + 1) + " " + ((i * (i * i)) + 1));
            }
        }
    }
}