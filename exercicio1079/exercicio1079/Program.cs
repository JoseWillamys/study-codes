using System;
using System.Globalization;

namespace exercicio1079 {
    class Program {
        static void Main(string[] args) {

            // média ponderada

            int n;
            double nota1, nota2, nota3, media;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = ((nota1 * 2.0) + (nota2 * 3.0) + (nota3 * 5.0)) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}