using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario, reajuste, novoSalario, percentual;
            salario = Convert.ToDouble(Console.ReadLine());
            salario = Math.Round(salario, 2);

            //insira os valores corretos de acordo com o enunciado

            if (salario >= 0.00 && salario <= 400.00)
            {
                reajuste = salario * 0.15;
                novoSalario = salario + reajuste;
                percentual = (reajuste / salario) * 100;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0:0} %", percentual);
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                percentual = (reajuste / salario) * 100;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0:0} %", percentual);
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                percentual = (reajuste / salario) * 100;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0:0} %", percentual);
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                percentual = (reajuste / salario) * 100;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0:0} %", percentual);
            }
            else if (salario > 2000.00)
            {
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
                percentual = (reajuste / salario) * 100;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0:0} %", percentual);
            }
            else Console.WriteLine("Sálario Inválido");

        }
    }
}
