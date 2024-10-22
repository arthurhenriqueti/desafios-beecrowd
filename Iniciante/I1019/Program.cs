using System;

namespace I1000
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int segundos = int.Parse(Console.ReadLine());

            var tempo = TimeSpan.FromSeconds(segundos);

            Console.WriteLine($"{tempo.Hours}:{tempo.Minutes}:{tempo.Seconds}");
        }
    }
}