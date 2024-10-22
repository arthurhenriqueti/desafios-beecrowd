using System;

namespace I1000
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int totalDias = int.Parse(Console.ReadLine());

            var dataInicial = new DateTime(1, 1, 1);

            var dataFinal = dataInicial.AddDays(totalDias);

            int anos = dataFinal.Year - dataInicial.Year;
            int meses = dataFinal.Month - dataInicial.Month;
            int dias = dataFinal.Day - dataInicial.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(dataFinal.Year, dataFinal.Month - 1);
            }
            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} meses(s)");
            Console.WriteLine($"{dias} dias(s)");
        }
    }
}