using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Runtime.Serialization;

namespace EstruturaFaçaEnquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            char repetir;

            do
            {
                Console.WriteLine("Digite a temperatura em Celsius: ");
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = 9.0 * c / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + f.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir (s/n)? ");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');

        }
    }
}
