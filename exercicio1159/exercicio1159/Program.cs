using System;

namespace exercicio1159 {
    class Program { 
        static void Main(string[] args) {

            // O programa deve ler um valor inteiro X indefinidas vezes.
            // (O programa irá parar quando o valor de X for igual a 0).
            // Para cada X lido, imprima a soma dos 5 pares consecutivos
            // a partir de X, inclusive o X , se for par. Se o valor de
            // entrada for 4, por exemplo, a saída deve ser 40, que é o
            // resultado da operação: 4+6+8+10+12, enquanto que se o valor
            // de entrada for 11, por exempo, a saída deve ser 80, que é a
            // soma de 12+14+16+18+20.

            int x, sequencia, cont, soma;

            x = int.Parse(Console.ReadLine());

            while (x != 0) { 
                
                if (x % 2 == 0) {
                    cont = 0;
                    sequencia = x;
                    soma = x;
                    
                    while (cont != 4) {
                        cont++;
                        sequencia = sequencia + 2;
                        soma += sequencia;
                    }

                    Console.WriteLine(soma);
                }
                else {
                    cont = 0;
                    sequencia = x + 1;
                    soma = x + 1;

                    while (cont != 4)
                    {
                        cont++;
                        sequencia = sequencia + 2;
                        soma += sequencia;
                    }

                    Console.WriteLine(soma);
                }

                x = int.Parse(Console.ReadLine());
            }
        }
    }
}