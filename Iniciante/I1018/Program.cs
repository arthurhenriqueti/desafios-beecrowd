using System;

namespace I1000
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int c100 = 0, c50 = 0, c20 = 0, c10 = 0, c5 = 0, c2 = 0, c1 = 0;

            int valor = int.Parse(Console.ReadLine());

            while (valor != 0)
            {
                if (valor >= 100)
                {
                    c100 += 1;
                    valor -= 100;
                } else if (valor >= 50)
                {
                    c50 += 1;
                    valor -= 50;
                } else if (valor >= 20)
                {
                    c20 += 1;
                    valor -= 20;
                } else if (valor >= 10)
                {
                    c10 += 1;
                    valor -= 10;
                } else if (valor >= 5)
                {
                    c5 += 1;
                    valor -= 5;
                }else if (valor >= 2)
                {
                    c2 += 1;
                    valor -= 2;
                } else if (valor >= 1)
                {
                    c1 += 1;
                    valor -= 1;
                } else
                {
                    Console.WriteLine("Valor inválido!");
                }
            }

            Console.WriteLine($"{c100} nota(s) de R$ 100,00");
            Console.WriteLine($"{c50} nota(s) de R$ 50,00");
            Console.WriteLine($"{c20} nota(s) de R$ 20,00");
            Console.WriteLine($"{c10} nota(s) de R$ 10,00");
            Console.WriteLine($"{c5} nota(s) de R$ 5,00");
            Console.WriteLine($"{c2} nota(s) de R$ 2,00");
            Console.WriteLine($"{c1} nota(s) de R$ 1,00");
        }
    }
}