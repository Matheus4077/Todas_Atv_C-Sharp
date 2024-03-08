using System;
using System.Globalization;

namespace ExercicioUrl1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, pi = 3.14159, R;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A = " + A.ToString("f4", CultureInfo.InvariantCulture));
            


        }
    }
}
