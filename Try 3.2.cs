using System;

public class CirclePrinter
{
    public static void Main(string[] args)
    {
        int radius = 5; //Радиус окружности

        //Цикл по строкам
        for (int y = -radius; y <= radius; y++)
        {
            //Цикл по столбцам
            for (int x = -radius; x <= radius; x++)
            {
                double distance = Math.Sqrt(x * x + y * y);

                // Если расстояние близко к радиусу, печатаем символ "*"
                if (Math.Abs(distance - radius) < 0.5) //Допуск для сглаживания
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" "); //Иначе пробел
                }
            }
            Console.WriteLine(); //Переход на след строку
        }
    }
}