using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Runtime.Serialization;

namespace MaiorEPosicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vamos considerar o primeiro valor como sendo incialmente o maior 
            int maior = int.Parse(Console.ReadLine());
            int posicao = 1;
            // agora vamos ler o segundo até o centésimo
            for (int i = 2; i <= 100; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > maior)
                {
                    maior = x;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
