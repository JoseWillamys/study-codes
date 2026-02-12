using System;

namespace exercicio1145 {
    class Program {
        static void Main(string[] args) {

            // Escreva um programa que leia dois valores X e Y. A seguir,
            // mostre uma sequência de 1 até Y, passando para a próxima linha
            // a cada X números.

            int x, y, cont = 1;

            string[] valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);

            for(int i = 1; i <= y; i++) { 
                if (cont < x) {
                    Console.Write(i + " ");
                    cont++;
                }
                else {
                    Console.WriteLine(i);
                    cont = 1;
                }
            }
        }
    }
}