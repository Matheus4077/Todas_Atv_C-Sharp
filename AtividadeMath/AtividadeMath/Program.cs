using System;
using System.Globalization;

namespace Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double b, a, area, perimento, diagonal;

            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * a;
            perimento = 2 * (b + a);
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

            Console.WriteLine("AREA = " + area.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimento.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("f4", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}