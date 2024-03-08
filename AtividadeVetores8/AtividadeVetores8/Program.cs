using System;
using System.Globalization;

namespace AtividadeVetores8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            char[] sexos = new char[n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(valores[0], CultureInfo.InvariantCulture);
                sexos[i] = char.Parse(valores[1]);
            }

            // menor altura
            double menorAltura = alturas[0];
            for (int i = 1; i < n; i++)
            {
                if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                }
            }
            Console.WriteLine("Menor altura = " + menorAltura.ToString("f2", CultureInfo.InvariantCulture));

            // maior alutra 
            double maiorAltura = alturas[0];
            for (int i = 1; i < n; i++)
            {
                if (alturas[i] > maiorAltura)
                {
                    maiorAltura = alturas[i];
                }
            }
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("f2", CultureInfo.InvariantCulture));

            //altura media das mulheres
            double somaDasAlturasDasMulheres = 0.0;
            int contMulheres = 0;
            for (int i = 0; i < n; i++)
            {
                if (sexos[i] == 'F')
                {
                    somaDasAlturasDasMulheres = somaDasAlturasDasMulheres + alturas[i];
                    contMulheres++;
                }
            }

            if (contMulheres == 0)
            {
                Console.WriteLine("Nao ha nenhuma mulher dentre as pessoas");
            }
            else
            {
                double media = somaDasAlturasDasMulheres / contMulheres;
                Console.WriteLine("Media das alturas das mulheres = " + media.ToString("f2", CultureInfo.InvariantCulture));
            }

            // numero de homens
            int contHomens = 0;
            for (int i = 0; i < n;i++)
            {
                if (sexos[i] == 'M')
                {
                    contHomens++;
                }
            }
            Console.WriteLine("Numero de homens = " + contHomens);
        }
    }
}
