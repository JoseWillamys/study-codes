using System;
using System.Globalization;

namespace exercicio1154 {
    class Program { 
        static void Main(string[] args) {

            // Faça um algoritmo para ler um número indeterminado de dados,
            // contendo cada um, a idade de um indivíduo. O último dado, que
            // não entrará nos cálculos, contém o valor de idade negativa.
            // Calcular e imprimir a idade média deste grupo de indivíduos.

            int idade, cont;
            double media, soma;

            soma = 0.0;
            cont = 0;
            idade = int.Parse(Console.ReadLine());

            while (idade >= 0) {
                soma += idade;
                cont++;
                idade = int.Parse(Console.ReadLine());
            }

            media = soma / cont;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}