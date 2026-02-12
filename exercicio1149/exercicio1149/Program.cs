using System;

namespace exercicio1149 { 
    class Program { 
        static void Main(string[] args) {


            // Faça um algoritmo para ler um valor A e um valor N. Imprimir a
            // soma de A + i para cada i com os valores (0 <= i <= N-1). Enquanto N
            // for negativo ou ZERO, um novo N(apenas N) deve ser lido.

            int a, n, i, soma;

            string[] valores = Console.ReadLine().Split(' ');

            a = int.Parse(valores[0]);
            i = 1;
            n = int.Parse(valores[1]);

            while (n <= 0) {
                i++;
                n = int.Parse(valores[i]);
            }

            soma = 0;

            for (i = 0; i < n; i++) {
                soma += a + i;
            }

            Console.WriteLine(soma);
        }
    }
}