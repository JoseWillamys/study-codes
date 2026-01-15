using System;

namespace exercicio1049
{
    class Program
    {
        static void Main(string[] args)
        {
            // Neste problema, você deverá ler 3 palavras que definem
            // o tipo de animal possível segundo o esquema abaixo, da
            // esquerda para a direita.  Em seguida conclua qual dos
            // animais seguintes foi escolhido, através das três palavras
            // fornecidas.

            string grupo, classe, alimentacao, animal;

            grupo = Console.ReadLine();
            classe = Console.ReadLine();
            alimentacao = Console.ReadLine();

            if (grupo == "vertebrado")
            {
                if (classe == "ave")
                {
                    if (alimentacao == "carnivoro")
                    {
                        animal = "aguia";
                    }
                    else
                    {
                        animal = "pomba";
                    }
                }
                else
                {
                    if (alimentacao == "onivoro")
                    {
                        animal = "homem";
                    }
                    else
                    {
                        animal = "vaca";
                    }
                }
            }
            else
            {
                if (classe == "inseto")
                {
                    if (alimentacao == "hematofago")
                    {
                        animal = "pulga";
                    }
                    else
                    {
                        animal = "lagarta";
                    }
                }
                else
                {
                    if (alimentacao == "hematofago")
                    {
                        animal = "sanguessuga";
                    }
                    else
                    {
                        animal = "minhoca";
                    }
                }
            }
            Console.WriteLine(animal);
        }
    }
}

