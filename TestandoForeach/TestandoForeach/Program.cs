using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace testeForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;

            n = int.Parse(Console.ReadLine());
            string[] vet = new string[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos:");

            foreach (string x in vet)
            {
                Console.WriteLine(x);
            }
        }
    }
}