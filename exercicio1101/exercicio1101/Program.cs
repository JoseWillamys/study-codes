using System;

namespace exercicio1101 { 
    class Program { 
        static void Main(string[] args) {

            // Leia um conjunto não determinado de pares de valores M e N
            // (parar quando algum dos valores for menor ou igual a zero).
            // Para cada par lido, mostre a sequência do menor até o maior
            // e a soma dos inteiros consecutivos entre eles (incluindo o N e M).

           // Entrada
           // O arquivo de entrada contém um número não determinado
           // de valores M e N.A última linha de entrada vai conter um número
           // nulo ou negativo.

            int min, max;

            for (int i = 1; i > 0; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                int m = int.Parse(valores[0]);
                int n = int.Parse(valores[1]);
                int soma = 0;

                if (m < n) {
                    min = m;
                    max = n;
                }
                else {
                    min = n;
                    max = m;
                }

                if (m <= 0 || n <= 0) {
                    i = -1;
                }
                else { 
                  for (int inicio = min; inicio <= max; inicio++) {
                        Console.Write(inicio + " ");
                        soma += inicio;
                  }
                    Console.WriteLine("Sum=" + soma);
                }
            }
        }
    }
}