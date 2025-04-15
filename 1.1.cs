using System;
public class PrimeNum
{
    public static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 2; i < n; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) Console.WriteLine(i);
        }
    }
}