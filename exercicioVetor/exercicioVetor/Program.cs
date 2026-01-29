using System;
using System.Globalization;

namespace exercicioVetor { 
    class Program { 
        static void Main(string[] args) {

            int n;
            double[] numeros;

            n = int.Parse(Console.ReadLine());
            numeros = new double[n];

            for (int i = 0; i < n; i++) {
                numeros[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++) {
                Console.WriteLine(numeros[i].ToString("F1", CultureInfo.InvariantCulture));
            }


        }
    }
}