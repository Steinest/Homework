using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число:");
        int n = Convert.ToInt32(Console.ReadLine());

        int num = n;

        while (num > 0) 
        {
            long fact = 1;

            //Вычисление факториала числа num
            for (int i = num; i > 0; i--) 
            {
                fact *= i;
            }

            Console.WriteLine($"Факториал числа {num}! = {fact}\n");

            num--;
        }
    }
}