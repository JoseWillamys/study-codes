using System;

namespace exercicio1142 {
    class Program {
        static void Main(string[] args) {

            // Escreva um programa que leia um valor inteiro N. Este N é a quantidade de
            // linhas de saída que serão apresentadas na execução do programa.
            
            // O arquivo de entrada contém um número inteiro positivo N.

            int n, num, num2, num3;

            num = 1;
            num2 = 2;
            num3 = 3;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine(num + " " + num2 + " " + num3 + " PUM");
                num += 4;
                num2 += 4;
                num3 += 4;
            }
        }
    }
}