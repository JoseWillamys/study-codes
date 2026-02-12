using System;

namespace exercicio1099 { 
    class Program { 
        static void Main(string[] args) {

            // Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir.
            // Cada caso de teste consiste de dois inteiros X e Y. Você deve apresentar a
            // soma de todos os ímpares existentes entre X e Y.

            int n, min, max;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                if (x < y) {
                    min = x;
                    max = y;
                }
                else {
                    min = y;
                    max = x;
                }

                int soma = 0;

                for (min += 1; min < max; min++) { 
                    if (min % 2 != 0) {
                        soma += min;
                    }
                }

                Console.WriteLine(soma);
            }
        }
    }
}