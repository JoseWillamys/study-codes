using System;

namespace study
{
    class exercicio03
    {
        static void Main(string[] args)
        {

            /*
             Fazer um programa para ler três números inteiros. Em seguida,
             mostrar qual o menor dentre os três números lidos. Em caso de
             empate, mostrar apenas uma vez.
             
            obs: os dados serão lidos em uma única linha, separados por espaço.
             */

            int num, num2, num3;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            num = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);
            num3 = int.Parse(vet[2]);

            if (num < num2 && num < num3) {
                Console.WriteLine("MENOR = " + num);
            } else if (num2 < num3) {
                Console.WriteLine("MENOR = " + num2);
            } else {
                Console.WriteLine("MENOR = " + num3);
            }
        }
    }
}
