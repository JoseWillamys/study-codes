using System;

namespace exercicio1046
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leia a hora inicial e a hora final de um jogo.
            // A seguir calcule a duração do jogo, sabendo que
            // o mesmo pode começar em um dia e terminar em outro,
            // tendo uma duração mínima de 1 hora e máxima de 24 horas.

            int h_inicio, h_final, duracao;
            string[] dados;

            dados = Console.ReadLine().Split(' ');
            h_inicio = int.Parse(dados[0]);
            h_final = int.Parse(dados[1]);

            if (h_inicio < h_final)
            {
                duracao = h_final - h_inicio;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
            else if (h_inicio == h_final)
            {
                duracao = 24;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
            else
            {
                duracao = (24 - h_inicio) + h_final;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
        }
    }
}
