using System;

namespace exercicio1134 {
    class Program { 
        static void Main(string[] args) {

            // Um Posto de combustíveis deseja determinar qual de seus produtos
            // tem a preferência de seus clientes. Escreva um algoritmo para
            // ler o tipo de combustível abastecido (codificado da seguinte
            // forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário
            // informe um código inválido (fora da faixa de 1 a 4) deve ser
            // solicitado um novo código (até que seja válido). O programa
            // será encerrado quando o código informado for o número 4.

            int produto, alcool, gasolina, diesel;
            bool proseguir = true;
            alcool = 0;
            gasolina = 0;
            diesel = 0;

            produto = int.Parse(Console.ReadLine());
            
            while (proseguir) { 
                switch (produto) {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    case 4:
                        proseguir = false;
                        Console.WriteLine("MUITO OBRIGADO");
                        Console.WriteLine("Alcool: " + alcool);
                        Console.WriteLine("Gasolina: " + gasolina);
                        Console.WriteLine("Diesel: " + diesel);
                        break;
                    default:
                        break;
                }

                if (proseguir) {
                    produto = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}