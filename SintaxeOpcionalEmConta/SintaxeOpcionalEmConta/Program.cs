using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace  SintaxeOpcionalEmConta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;
            if (minutos > 100)
            {
                conta += (minutos - 100) * 2.0;
                // a += b        ==       a = a + b;
                // a -= b        ==       a = a - b;
                // a *= b        ==       a = a * b;
                // a /= b        ==       a = a / b;
                // a %= b        ==       a = a % b;
            }

            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("f2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}