using System;
using System.Globalization;

namespace AulaSaidaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.WriteLine("Olá mundo");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até Mais.");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("f2"));
            Console.WriteLine(x.ToString("f4"));
            Console.WriteLine(x.ToString("f2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("RESUTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais ");
            Console.WriteLine("O valor do troco é " + x.ToString("f2") + " reais ");

            Console.WriteLine();
            Console.WriteLine("A Paciente " + z + " tem " + 32 + " anos e seu sexo é  " + w);

            Console.WriteLine();

        }
    }
}