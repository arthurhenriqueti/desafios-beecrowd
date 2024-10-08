using System;

namespace I1011
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());

            double volume = ((4.0 / 3.0) * Math.PI * Math.Pow(raio, 3));

            Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
        }
    }
}