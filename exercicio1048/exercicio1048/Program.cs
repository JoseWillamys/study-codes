using System;
using System.Globalization;

namespace exercicio1048
{
    class Program
    {
        static void Main(string[] args)
        {
            //A empresa ABC resolveu conceder um aumento de salários
            //a seus funcionários de acordo com a tabela.

            // Salário	Percentual de Reajuste
            // 0 - 400.00  15%
            // 400.01 - 800.00  12%
            // 800.01 - 1200.00  10%
            // 1200.01 - 2000.00  7%
            // Acima de 2000.00  4%

            //Leia o salário do funcionário e calcule e mostre o novo
            //salário, bem como o valor de reajuste ganho e o índice
            //reajustado, em percentual.

            double salario, reajuste, novoSalario;
            int percentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario > 2000.0)
            {
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
            else if (salario >= 1200.01)
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salario >= 800.01)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario >= 400.01)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else
            {
                reajuste = salario * 0.15;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
        }
    }
}