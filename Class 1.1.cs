using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Программа обмена значений двух переменных без временной переменной");

        Console.Write("Введите переменную a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите переменную b: ");
        int b = int.Parse(Console.ReadLine());

        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"Переменная a = {a}, переменная b = {b}");
    }
}