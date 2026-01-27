using System;
using System.Globalization;

namespace exercicio1118 { 
    class Program { 
        static void Main(string[] args) {

            // Escreva um programa para ler as notas da primeira e a segunda avaliação
            // de um aluno. Calcule e imprima a média semestral. O programa só deverá
            // aceitar notas válidas (uma nota válida deve pertencer ao intervalo [0,10]).
            // Cada nota deve ser validada separadamente.

            // No final deve ser impressa a mensagem “novo calculo(1 - sim 2 - nao)”,
            // solicitando ao usuário que informe um código(1 ou 2) indicando se ele
            // deseja ou não executar o algoritmo novamente, (aceitar apenas os código
            // 1 ou 2). Se for informado o código 1 deve ser repetida a execução de todo
            // o programa para permitir um novo cálculo, caso contrário o programa deve
            // ser encerrado.
            

            double nota, acum, media;
            int cont, prosseguir;

            cont = 0;
            prosseguir = 1;
            acum = 0.0;
            nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (prosseguir != 2) {
               
                if (nota >= 0.0 && nota <= 10.0 && cont < 2) {
                    acum += nota;
                    cont++;
                }
                else if (cont < 2) {
                        Console.WriteLine("nota invalida");
                }

                if (cont < 2) {
                    nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                } 
                else {
                    media = acum / cont;
                    Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
                    
                    media = 0.0;
                    acum = 0.0;
                    cont = 0;

                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    prosseguir = int.Parse(Console.ReadLine());

                    while (prosseguir != 1 && prosseguir != 2) {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        prosseguir = int.Parse(Console.ReadLine());
                    }

                    if(prosseguir == 1) {
                        nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                }
            }
        }
    }
}