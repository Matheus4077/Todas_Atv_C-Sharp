﻿using System;
using System.Globalization;

namespace EntradaDeDados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char Sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(Sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
