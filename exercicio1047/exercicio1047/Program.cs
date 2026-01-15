using System;

namespace exercico1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int hInicial, mInicial, hFinal, mFinal, minutosInicial, minutosFinal, duracao, hora, minuto;

            string[] valores = Console.ReadLine().Split(' ');

            hInicial = int.Parse(valores[0]);
            mInicial = int.Parse(valores[1]);
            hFinal = int.Parse(valores[2]);
            mFinal = int.Parse(valores[3]);

            // transformando tudo em minutos
            minutosInicial = hInicial * 60 + mInicial;
            minutosFinal = hFinal * 60 + mFinal;
        
            if (minutosInicial < minutosFinal)
            {
               duracao = minutosFinal - minutosInicial;
            } 
            else
            {
                duracao = (24 * 60 - minutosInicial) + minutosFinal; 
            }

            hora = duracao / 60;
            minuto = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + hora + " HORA(S) E " + minuto + " MINUTO(S)");
        }
    }
}