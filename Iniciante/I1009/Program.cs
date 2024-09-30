using System;

namespace I1009
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String nome = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());

            double bonus = (vendas * 0.15);

            Console.WriteLine($"TOTAL = R$ {(salarioFixo + bonus).ToString("F2")}");
        }
    }
}