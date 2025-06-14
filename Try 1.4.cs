using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите три целых числа:");

        int num1 = GetIntFromConsole("Первое число: ");
        int num2 = GetIntFromConsole("Второе число: ");
        int num3 = GetIntFromConsole("Третье число: ");

        int result = 0;

        //Проходим по каждому биту
        for (int i = 0; i < 32; i++)
        {
            //Извлекаем i-й бит
            int bit1 = (num1 >> i) & 1;
            int bit2 = (num2 >> i) & 1;
            int bit3 = (num3 >> i) & 1;

            //Считаем, сколько раз встречается 1
            int onesCount = bit1 + bit2 + bit3;

            //Определяем наиболее частый бит
            int mostBit = (onesCount >= 2) ? 1 : 0;

            //Устанавливаем i-й бит в результате
            if (mostBit == 1)
            {
                result |= (1 << i);
            }
        }

        Console.WriteLine($"Результирующее число: {result}");
    }

    //Вспомогательная функция
    static int GetIntFromConsole(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }
    }
}