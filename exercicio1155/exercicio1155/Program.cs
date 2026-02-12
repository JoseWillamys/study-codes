using System;
using System.Globalization;

namespace exercicio1155 { 
    class Program { 
        static void Main(string[] args) {

            // Escreva um algoritmo para calcular e escrever o valor de S,
            // sendo S dado pela fórmula:
            // S = 1 + 1 / 2 + 1 / 3 + … +1 / 100

            double s = 0.0;

            for (int i = 1; i <= 100; i++) {
                s = s + 1.0 / i;
            }
            
            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}