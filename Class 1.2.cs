using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число:");
        string str = Console.ReadLine(); //Вводим с консоли число str

        //Проверка
        if (!long.TryParse(str, out long n) || n <= 0)
        {
            Console.WriteLine("Введено некорректное натуральное число.");
            return;
        }

        //Сортируем символы в числе в порядке возрастания
        string sortedStr = string.Concat(str.OrderBy(c => c));

        if (sortedStr.Length > 1 && sortedStr[0] == '0')
        {
            int firstNonZeroIndex = 0;
            for (int i = 0; i < sortedStr.Length; i++)
            {
                if (sortedStr[i] != '0')
                {
                    firstNonZeroIndex = i;
                    break;
                }
            }

            // Перемещаем первую ненулевую цифру в начало строки
            sortedStr = sortedStr[firstNonZeroIndex] + sortedStr.Substring(0, firstNonZeroIndex) + sortedStr.Substring(firstNonZeroIndex + 1);
        }

        Console.WriteLine(sortedStr);
    }
}