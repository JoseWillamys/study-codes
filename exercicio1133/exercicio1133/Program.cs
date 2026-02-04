using System;
using System.Runtime.Intrinsics.Arm;

namespace exercicio1133 {
    class Program {
        static void Main(string[] args) {

            // Escreva um programa que leia 2 valores X e Y e que imprima todos os valores
            // entre eles cujo resto da divisão dele por 5 for igual a 2 ou igual a 3.

            // O arquivo de entrada contém 2 valores positivos inteiros quaisquer, não
            // necessariamente em ordem crescente.

            int x, y, min, max;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y) {
                min = x;
                max = y;
            }
            else {
                min = y;
                max = x;
            }

            for (int i = min + 1; i < max; i++) { 
                if (i % 5 == 3 || i % 5 == 2) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}