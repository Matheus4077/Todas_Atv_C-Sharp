using System;
using System.Globalization;

namespace AtividadeVetores6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                idades[i] = int.Parse(valores[1]);
            }

            // enconrando a posicao da maior idade
            int maiorIdade = idades[0];
            int posicaoMaiorIdade = 0;

            for (int i = 0;i < n;i++)
            {
                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                    posicaoMaiorIdade = i ;
                }
            }

            // acessando o vetor de nomes na posicao da maior idade

            Console.WriteLine("Pessoa mais velha: " + nomes[posicaoMaiorIdade]);

        }
    }
}