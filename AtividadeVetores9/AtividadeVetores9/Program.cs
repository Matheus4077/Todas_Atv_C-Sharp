using System;
using System.Globalization;

namespace AtividadeVetores8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] compras = new double[n];
            double[] vendas = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                compras[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
                vendas[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
            }

            // encontrando quantidades para cada faixa de lucro
            int contAbaixoDe10 = 0;
            int contEntre10E20 = 0;
            int contAcimaDe20 = 0;
            for (int i = 0;i < n; i++)
            {
                double lucro = vendas[i] - compras[i];

                double porcentagemDeLucro = lucro / compras[i] * 100.0;

                if (porcentagemDeLucro < 10.0)
                {
                    contAbaixoDe10++;
                }
                else if (porcentagemDeLucro <= 20.0)
                {
                    contEntre10E20++;
                }
                else
                {
                    contAcimaDe20++;
                } 
            }
            Console.WriteLine("Lucro abaixo de 10%: " + contAbaixoDe10);
            Console.WriteLine("Lucro entre 10% e 20%: " + contEntre10E20);
            Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);

            // achando os totais 
            double totalCompra = 0.0;
            double totalVendas = 0.0;
            for (int i = 0; i < n; i++)
            {
                totalCompra = totalCompra + compras[i];
                totalVendas = totalVendas + vendas[i];
            }
            double totalLucro = totalVendas - totalCompra;

            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalVendas.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + totalLucro.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}