using System;

namespace exercicio1067 { 
    class Program { 
        static void Main(string[] args) {
            int valor;

            valor = int.Parse(Console.ReadLine());

            for (int i = 0; i <= valor; i++) { 
                if ( i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}