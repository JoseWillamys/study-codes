using System;
using System.Globalization;

namespace exercicio1116 { 
    class Program { 
        static void Main(string[] args) {

            // Escreva um algoritmo que leia 2 números e imprima o resultado da divisão
            // do primeiro pelo segundo. Caso não for possível mostre a mensagem “divisao
            // impossivel” para os valores em questão.

            // A entrada contém um número inteiro N. Este N será a quantidade de pares de
            // valores inteiros(X e Y) que serão lidos em seguida.


            int n, x, y;
            double resultado;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

                if (y == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    resultado = (double)x / (double)y;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}