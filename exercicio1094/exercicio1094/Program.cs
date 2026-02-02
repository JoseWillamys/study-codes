using System;
using System.Globalization;

namespace exercicio1094 { 
    class Program { 
        static void Main(string[] args) {

            // Maria acabou de iniciar seu curso de graduação na faculdade de medicina
            // e precisa de sua ajuda para organizar os experimentos de um laboratório
            // o qual ela é responsável. Ela quer saber no final do ano, quantas cobaias
            // foram utilizadas no laboratório e o percentual de cada tipo de cobaia
            // utilizada.

            // Este laboratório em especial utiliza três tipos de cobaias: sapos, ratos e
            // coelhos.Para obter estas informações, ela sabe exatamente o número de
            // experimentos que foram realizados, o tipo de cobaia utilizada e a quantidade
            // de cobaias utilizadas em cada experimento.

            int n, coelhos, ratos, sapos, total;
            double percentualC, percentualR, percentualS;

            total = 0;
            coelhos = 0;
            ratos = 0;
            sapos = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] dados = Console.ReadLine().Split(' ');
                int quantidade = int.Parse(dados[0]);
                char tipo = char.Parse(dados[1]);

                total += quantidade; 

                if (tipo == 'C') {
                    coelhos += quantidade;
                }
                else if (tipo == 'R') { 
                    ratos += quantidade;
                }
                else { 
                    sapos += quantidade;
                }
            }

            percentualC = (double)coelhos / (double)total * 100;
            percentualR = (double)ratos / (double)total * 100;
            percentualS = (double)sapos / (double)total * 100;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + percentualC.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + percentualR.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + percentualS.ToString("F2", CultureInfo.InvariantCulture) + " %");

        }
    }
}