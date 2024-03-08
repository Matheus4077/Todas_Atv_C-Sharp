using System;
using System.Globalization;

namespace ArividadeVetores2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(valores[i]);
            }
            
            // mostrando numeros pares
            for (int i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                }
            }
            Console.WriteLine();

            // mostrando quantidade dos pares
            int QuantidadeDePares = 0;
            for (int i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    QuantidadeDePares++;
                }
            }

            Console.WriteLine(QuantidadeDePares);

        }
    }
}