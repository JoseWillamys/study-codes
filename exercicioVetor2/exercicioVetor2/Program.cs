using System;

namespace exercicioVetor2 { 
    class Program { 
        static void Main(string[] args) {
            int N;
            int[] numeros;

            N = int.Parse(Console.ReadLine());
            numeros = new int[N];

            string[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                numeros[i] = int.Parse(vet[i]);

                if (numeros[i] < 0) {
                    Console.WriteLine(numeros[i]);
                }
            }
        }
    }
}