using System;

namespace I1010
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int cod1 = int.Parse(Console.ReadLine());
            int qtd1 = int.Parse(Console.ReadLine());
            double valor1 = double.Parse(Console.ReadLine());

            int cod2 = int.Parse(Console.ReadLine());
            int qtd2 = int.Parse(Console.ReadLine());
            double valor2 = double.Parse(Console.ReadLine());

            double valorTotal = ((qtd1 * valor1) + (qtd2 * valor2));

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal.ToString("F2")}");
        }
    }
}