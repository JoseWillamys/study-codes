using System;
using System.Globalization;
namespace exEstruturaRepetitiva02 { 
    class Program { 
        static void Main(string[] args) {

            // Faça um programa para ler um número indeterminado de dados, contendo cada um,
            // a idade de um indivíduo. O último dado, que não entrará nos cálculos, contém
            // um valor de idade negativa. Calcular e imprimir a idade média deste grupo de
            // indivíduos. Se for entrado um valor negativo na primeira vez, mostrar a 
            // mensagem "impossivel calcular".

            int  cont;
            double idade, somaIdades, media;

            cont = 0;
            somaIdades = 0.0;

            idade = int.Parse(Console.ReadLine());
            
            while (idade >= 0) {
                cont++;
                somaIdades += idade;
                idade = int.Parse(Console.ReadLine());
            }

            if (cont == 0) {
                Console.WriteLine("impossivel calcular");
            } else {
                media = somaIdades / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}