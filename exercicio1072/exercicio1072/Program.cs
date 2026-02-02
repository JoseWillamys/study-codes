using System;

namespace exercicio1072 { 
    class Program { 
        static void Main(string[] args) {

            // Leia um valor inteiro N. Este valor será a quantidade de valores
            // inteiros X que serão lidos em seguida.

            //Mostre quantos destes valores X estão dentro do intervalo[10, 20]
            //e quantos estão fora do intervalo, mostrando essas informações.

            int n, dentro, fora ;
            
            dentro = 0;
            fora = 0 ;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                int valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <= 20) {
                    dentro++;
                }
                else {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}