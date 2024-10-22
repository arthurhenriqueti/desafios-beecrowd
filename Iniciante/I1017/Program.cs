using System;

namespace I1000
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            int velMedia = int.Parse(Console.ReadLine());

            double distancia = tempo * velMedia;
            double litrosGastos = distancia / 12;

            Console.WriteLine($"{litrosGastos.ToString("F3")}");
        }
    }
}