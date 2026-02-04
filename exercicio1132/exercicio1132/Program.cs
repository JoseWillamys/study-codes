using System;

namespace exercicio1132 { 
    class Program { 
        static void Main(string[] args) {

            // Escreva um algoritmo que leia 2 valores inteiros X e Y calcule a soma dos
            // números que não são múltiplos de 13 entre X e Y, incluindo ambos.

            // O arquivo de entrada contém 2 valores inteiros quaisquer,
            // não necessariamente em ordem crescente.

            int x, y, soma, min, max;

            soma = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                min = x;
                max = y;
            }
            else { 
                min = y; max = x;
            }

            for (int i = min; i <= max; i++) { 
                if (i % 13 != 0) {
                    soma += i;  
                }
            }

            Console.WriteLine(soma);
        }
    }
}