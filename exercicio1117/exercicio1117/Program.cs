using System;
using System.Globalization;

namespace exercicio1117 { 
    class Program { 
        static void Main(string[] args) {

            //Faça um programa que leia as notas referentes às duas avaliações
            //de um aluno. Calcule e imprima a média semestral. Faça com que o
            //algoritmo só aceite notas válidas (uma nota válida deve pertencer
            //ao intervalo [0,10]). Cada nota deve ser validada separadamente.

            double nota, acum, media;
            int cont = 0;
            
            acum = 0.0;
            nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (cont < 2)
            {
                if (nota >= 0.0 && nota <= 10.0) {
                    cont++;
                    acum += nota;

                    if (cont == 2) {
                        media = acum / cont;
                        Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
                    }
                    else {
                        nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                }
                else {
                    Console.WriteLine("nota invalida");
                    nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }
        }
    }
}