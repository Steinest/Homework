using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1,  2,  3,  4,  5 },
            { 6,  7,  8,  9, 10 },
            {11, 12, 13, 14, 15 },
            {16, 17, 18, 19, 20 },
            {21, 22, 23, 24, 25 }
        };
        Spiral(array);
    }

    static void Spiral(int[,] array)
    {
        int n = array.GetLength(0);
        if (n % 2 == 0)
        {
            Console.WriteLine("Размер массива должен быть нечетным!");
            return;
        }

        int center = n / 2;
        int x = center, y = center;
        Console.Write(array[y, x] + " ");

        for (int step = 1; step < n; step++)
        {
            for (int i = 0; i < step; i++) //Право
            {
                x++;
                if (x < n) Console.Write(array[y, x] + " ");
            }

            for (int i = 0; i < step; i++) //Низ
            {
                y++;
                if (y < n) Console.Write(array[y, x] + " ");
            }

            step++;
            if (step >= n) break;

            for (int i = 0; i < step; i++) //Лево
            {
                x--;
                if (x >= 0) Console.Write(array[y, x] + " ");
            }

            for (int i = 0; i < step; i++) //Верх
            {
                y--;
                if (y >= 0) Console.Write(array[y, x] + " ");
            }
        }
    }
}