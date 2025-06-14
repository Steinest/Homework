using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 65, 6381, 549, 2004, -90, 8 };

        //Список для хранения чисел с максимальной суммой цифр
        List<int> maxDigitSumNumbers = new List<int>();
        int maxSum = int.MinValue;

        // Перебираем все числа в массиве
        foreach (int number in numbers)
        {
            int digitSum = CalculateDigitSum(number);

            //Если текущая сумма цифр больше, чем максимальная найденная ранее
            if (digitSum > maxSum)
            {
                maxSum = digitSum; //Обновляем максимальную сумму цифр
                maxDigitSumNumbers.Clear(); //Очищаем список, так как нашли новое максимальное значение
                maxDigitSumNumbers.Add(number); //Добавляем текущее число в список
            }

            else if (digitSum == maxSum)
            {
                maxDigitSumNumbers.Add(number);
            }
        }

        if (maxDigitSumNumbers.Count > 0)
        {
            Console.WriteLine("Числа с наибольшей суммой цифр:");
            foreach (int number in maxDigitSumNumbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("В массиве нет чисел.");
        }

    }

    //Вычисление суммы цифр числа
    static int CalculateDigitSum(int number)
    {
        number = Math.Abs(number);
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}