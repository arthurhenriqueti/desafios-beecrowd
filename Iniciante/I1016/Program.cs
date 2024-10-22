using System;

namespace I1000
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int distKm = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(distKm * 2)} minuto(s)");
        }
    }
}