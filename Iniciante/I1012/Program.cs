using System;

namespace I1012
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            Console.WriteLine($"TRIANGULO = {(A * C / 2).ToString("F3")}");
            Console.WriteLine($"CIRCULO = {(Math.PI * Math.Pow(C, 2)).ToString("F3")}");
            Console.WriteLine($"TRAPEZIO = {((A + B) * C / 2).ToString("F3")}");
            Console.WriteLine($"QUADRADO = {(Math.Pow(B, 2)).ToString("F3")}");
            Console.WriteLine($"RETANGULO = {(A * B).ToString("F3")}");
        }
    }
}