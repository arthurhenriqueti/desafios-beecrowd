using System;

namespace I1014
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(X / Y).ToString("F3")} km/l");
        }
    }
}