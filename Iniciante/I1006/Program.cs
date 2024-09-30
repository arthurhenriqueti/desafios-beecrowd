using System;

namespace I1006
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double MEDIA = (((A * 2.0) + (B * 3) + (C * 5)) / 10);

            Console.WriteLine($"MEDIA = {MEDIA.ToString("F1")}");
        }
    }
}