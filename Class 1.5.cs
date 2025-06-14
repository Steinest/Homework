using System;

class Program
{
    static void Main(string[] args)
    {
        double delim = Math.Sin(5) + Math.Pow(1.75, 2);

        double delit = 3 * Math.Exp(Math.Cos(7));

        if (delit == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль!");
        }
        else
        {
            double result = delim/delit;

            Console.WriteLine($"Результат выражения: {result}");
        }
        Console.ReadKey();
    }
}