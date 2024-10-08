using System;

namespace I1013
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            if (A > B && A > C)
            {
                Console.WriteLine($"{A} é o maior!");
            } else if (B > A && B > C)
            {
                Console.WriteLine($"{B} é o maior!");
            } else
            {
                Console.WriteLine($"{C} é o maior!");
            }
        }
    }
}