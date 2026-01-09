using System;
using System.Globalization;
namespace exercicio1038
{
    class Program
    {
        static void Main(string[] args)
        {
            // Com base na tabela abaixo, escreva um programa que leia
            // o código de um item e a quantidade deste item.
            // A seguir, calcule e mostre o valor da conta a pagar.

            float quantidade, valor, total;
            int produto;
            string[] dados;

            dados = Console.ReadLine().Split(' ');

            produto = int.Parse(dados[0]);
            quantidade = float.Parse(dados[1]);
            
            switch (produto){
                case 1:
                    valor = 4.0f;
                    total = valor * quantidade;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    valor = 4.50f;
                    total = valor * quantidade;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    valor = 5.0f;
                    total = valor * quantidade;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    valor = 2.0f;
                    total = valor * quantidade;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    valor = 1.50f;
                    total = valor * quantidade;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                default:
                    break;
            }
        }
    }
}