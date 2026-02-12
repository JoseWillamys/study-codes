using System;
using System.Globalization;

namespace exercicio1156
{
    class Program
    {
        static void Main(string[] args)
        {

            // Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
            // S = 1 + 3 / 2 + 5 / 4 + 7 / 8 + ... +39 /?

            int num;
            double den = 1.0, soma = 0.0;

            for (num = 1; num <= 39; num += 2)
            {
                soma = soma + num / den;
                den = den * 2;
        
            }

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}