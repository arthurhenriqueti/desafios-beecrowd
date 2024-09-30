using System;

namespace I1002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const double PI = Math.PI;
            double raio = double.Parse(Console.ReadLine());

            double area = (PI * Math.Pow(raio, 2));

            Console.WriteLine($"A={area.ToString("F4")}");
        }
    }
}