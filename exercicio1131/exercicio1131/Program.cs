using System;
using System.Runtime.Intrinsics.X86;

namespace exercicio1131 { 
    class Program { 
        static void Main(string[] args) {

            // A Federação Gaúcha de Futebol contratou você para escrever um programa para
            // fazer uma estatística do resultado de vários GRENAIS. Escreva um programa
            // para ler o número de gols marcados pelo Inter e pelo Grêmio em um GRENAL.
            // Logo após escrever a mensagem "Novo grenal (1-sim 2-nao)" e solicitar uma
            // resposta. Se a resposta for 1, o algoritmo deve ser executado novamente
            // solicitando o número de gols marcados pelos times em uma nova partida,
            // caso contrário deve ser encerrado imprimindo:

            /*
            -Quantos GRENAIS fizeram parte da estatística.
            - O número de vitórias do Inter.
            - O número de vitórias do Grêmio.
            - O número de Empates.
            -Uma mensagem indicando qual o time que venceu o maior número 
            de GRENAIS(ou "Nao houve vencedor", caso termine empatado).
            */

            int novoGrenal, vitoriasInter, vitoriasGremio, empates, cont;
            
            novoGrenal = 1;
            vitoriasInter = 0;
            vitoriasGremio = 0;
            empates = 0;
            cont = 0;

            while (novoGrenal == 1) {

                string[] gols = Console.ReadLine().Split(' ');
                int interG = int.Parse(gols[0]);
                int gremioG = int.Parse(gols[1]);
                cont++;

                if (interG > gremioG) {
                    vitoriasInter++;
                }
                else if (interG == gremioG){
                    empates++;
                }
                else {
                    vitoriasGremio++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(cont + " grenais");
            Console.WriteLine("Inter:" + vitoriasInter);
            Console.WriteLine("Gremio:" + vitoriasGremio);
            Console.WriteLine("Empates:" + empates);

            if (vitoriasInter > vitoriasGremio) {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriasInter == vitoriasGremio) {
                Console.WriteLine("Nao houve vencedor");
            }
            else {
                Console.WriteLine("Gremio venceu mais");
            }
        }
    }
}