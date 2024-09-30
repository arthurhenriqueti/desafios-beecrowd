using System;

namespace I1005
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            double MEDIA = (((A * 3.5) + (B * 7.5)) / 11.0);

            Console.WriteLine($"MEDIA = {MEDIA.ToString("F5")}");
        }
    }
}