using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace ReagusteSalarial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double percentual;

            if (salario <= 400.0)
            {
                percentual = 15.0;
            }
            else if (salario <= 800.0)
            {
                percentual = 12.0;
            }
            else if (salario <= 1200.0)
            {
                percentual = 10.0;
            }
            else if (salario <= 2000.0)
            {
                percentual = 7.0;
            }
            else
            {
                percentual = 4.0;
            }

            double reajuste = salario * percentual / 100.0;
            double novosalario = salario + reajuste;

            Console.WriteLine("Novo salario: " + novosalario.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("f0", CultureInfo.InvariantCulture) + " %");

            Console.ReadLine();
        }
    }
}