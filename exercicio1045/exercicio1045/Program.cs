using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace exercicio1045
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Leia 3 valores de ponto flutuante A, B e C e ordene - os em ordem decrescente, 
            de modo que o lado A representa o maior dos 3 lados.A seguir, determine o tipo 
            de triângulo que estes três lados formam, com base nos seguintes casos, sempre 
            escrevendo uma mensagem adequada:

            se A ≥ B + C, apresente a mensagem: NAO FORMA TRIANGULO
            se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
            se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
            se A2<B2 +C2, apresente a mensagem: TRIANGULO ACUTANGULO
            se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
            se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES

            */

            double a, b, c;

            string[] valores = Console.ReadLine().Split(' ');
            
            double valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            
            if (valor1 > valor2 && valor1 > valor3)
            {
                a = valor1;
                if (valor2 > valor3)
                {
                    b = valor2;
                    c = valor3;
                }
                else
                {
                    b = valor3;
                    c = valor2;
                }
            } 
            else if (valor2 > valor3)
            {
                a = valor2;
                if (valor1 > valor3)
                {
                    b = valor1;
                    c = valor3;
                } 
                else
                {
                    b = valor3;
                    c = valor1;
                }
            } 
            else 
            {
                a = valor3;
                if (valor1 > valor2)
                {
                    b = valor1;
                    c = valor2;
                }
                else
                {
                    b = valor2;
                    c = valor1;
                }
            }

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(a, 2.0) == Math.Pow(b, 2.0) + Math.Pow(c, 2.0))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(a, 2.0) > Math.Pow(b, 2.0) + Math.Pow(c, 2.0))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (a == b && a == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}