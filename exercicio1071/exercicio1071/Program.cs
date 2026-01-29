using System;

namespace exercicio1071 { 
    class Program { 
        static void Main(string[] args) {

            int x, y, inicio, final, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y) {
                inicio = x;
                final = y;
            }
            else {
                inicio = y;
                final = x;
            }

            soma = 0;

            for (int i = inicio + 1; i < final; i++) { 
                if (i % 2 != 0) {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}