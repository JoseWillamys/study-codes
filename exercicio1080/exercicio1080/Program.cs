using System;

namespace exercicio1080 {
    class Program {
        static void Main(string[] args) {

            // Leia 100 valores inteiros. Apresente então o maior valor lido
            // e a posição dentre os 100 valores lidos.

            int max, posicao;
            max = 0;
            posicao = 0;

            for (int i = 1; i <= 100; i++) {
                int numero = int.Parse(Console.ReadLine());

                if (numero > max) {
                    max = numero;
                    posicao = i;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(posicao);
        }
    }
}