using System;
using System.Globalization;

namespace IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, ANOS, MESES, DIAS, RESTO;

            N = int.Parse(Console.ReadLine());

            ANOS = N / 365;
            RESTO = N % 365;
            MESES = RESTO / 30;
            DIAS = RESTO % 30;

            Console.WriteLine(ANOS + " ano(s)");
            Console.WriteLine(MESES + " mes(es)");
            Console.WriteLine(DIAS + " dia(s)");           
        }
    }
}
