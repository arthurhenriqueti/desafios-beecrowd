using System;

namespace I1008
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int id = int.Parse(Console.ReadLine());
            int qtdHoras = int.Parse(Console.ReadLine());
            double valorPorHora = double.Parse(Console.ReadLine());

            double salario = (qtdHoras * valorPorHora);

            Console.WriteLine($"NUMBER = {id}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2")}");
        }
    }
}