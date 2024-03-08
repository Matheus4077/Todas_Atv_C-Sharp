using System;
namespace ArividadeVetores3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(valores[i]);
            }

            valores = Console.ReadLine().Split(' ');
            for(int i = 0;i < n; i++)
            {
                b[i] = int.Parse(valores[i]);
            }

            // gerando vetor c
            int[] c = new int[n];
            for (int i = 0; i < n; i++)
            {
                c[i] = a[i] + b[i];
            }
             
            
            for (int i = 0; i < n ; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.WriteLine();

        }
    }
}