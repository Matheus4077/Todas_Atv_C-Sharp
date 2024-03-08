using System;
using System.Globalization;

namespace AtividadeVetores7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] notasSemestre1 = new double[n];
            double[] notasSemestre2 = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                notasSemestre1[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
                notasSemestre2[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Alunos aprovados: ");
            for (int i = 0;i < n; i++)
            {
                double media = (notasSemestre1[i] + notasSemestre2[i]) / 2.0;
                if (media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }

        }
    }
}