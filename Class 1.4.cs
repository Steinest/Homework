using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c, result;

        Console.WriteLine("Введите значение a: ");
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Введите вещественное число для a: ");
        }

        Console.WriteLine("Введите значение b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Введите вещественное число для b: ");
        }

        Console.WriteLine("Введите значение c: ");
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Введите вещественное число для c: ");
        }

        double delimoe = Math.Pow((a * b + 7 * c), 3) - (a * a + b * b + c * c);
        double delitel = b - a * c - a * (b + c);

        if (delitel == 0)
        {
            Console.WriteLine("Деление на ноль");
        }
        else
        {
            result = delimoe / delitel;
            Console.WriteLine($"Результат: {result}");
        }
    }
}