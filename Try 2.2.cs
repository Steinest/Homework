using System;
using System.Diagnostics;

public class FactorialComparison
{
    public static long RecursiveFactorial(int n)
    {
        if (n <= 1) return 1;
        return n * RecursiveFactorial(n - 1);
    }

    public static long IterativeFactorial(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число для вычисления факториала:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("\nРезультаты вычисления:");
        Console.WriteLine($"Рекурсивно: {RecursiveFactorial(number)}");
        Console.WriteLine($"Итеративно: {IterativeFactorial(number)}");
    }
}