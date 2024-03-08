using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace AtividadeVetores4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            string[] valores = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0;i < n; i++)
            {
                soma = soma + vet[i];
            }

            double media =0.0;
            for (int i = 0; i < n; i++)
            {
                media = soma / n;
            }
            Console.WriteLine(media.ToString("f1",CultureInfo.InvariantCulture));
        }
    }
}
