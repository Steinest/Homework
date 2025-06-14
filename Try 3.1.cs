using System;

class BinaryAddition
{
    static void Main(string[] args)
    {
        //Ввод чисел
        Console.Write("Введите первое число (int): ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число (int): ");
        int num2 = int.Parse(Console.ReadLine());

        //Преобразование в двоичный вид (дополнительный код)
        string bin1 = ToBinaryInTwoSComplement(num1);
        string bin2 = ToBinaryInTwoSComplement(num2);

        Console.WriteLine("\nДвоичное представление:");
        Console.WriteLine($"Число 1: {bin1}");
        Console.WriteLine($"Число 2: {bin2}");

        //Сложение
        string sumBinary = AddBinaryStrings(bin1, bin2);
        Console.WriteLine($"\nСумма в двоичном виде: {sumBinary}");

        //Преобразование в десятичный вид
        int decimalSum = ConvertBinaryToDecimal(sumBinary);
        Console.WriteLine($"Сумма в десятичном виде: {decimalSum}");
    }

    // Перевод числа в двоичное представление (дополнительный код)
    static string ToBinaryInTwoSComplement(int num)
    {
        uint unsigned = (uint)num;
        return Convert.ToString(unsigned, 2).PadLeft(32, '0');
    }

    // Сложение двоичных чисел
    static string AddBinaryStrings(string a, string b)
    {
        char[] result = new char[32];
        int carry = 0;

        for (int i = 31; i >= 0; i--)
        {
            int digit1 = a[i] - '0';
            int digit2 = b[i] - '0';
            int sum = digit1 + digit2 + carry;

            carry = sum/2; 
            result[i] = (char)((sum % 2) + '0'); 
        }

        return new string(result);
    }

    // Преобразование двоичного числа в десятичное
    static int ConvertBinaryToDecimal(string binary)
    {
        if (binary[0] == '1')
        {
            char[] inverted = new char[32];
            for (int i = 0; i < 32; i++)
                inverted[i] = binary[i] == '0' ? '1' : '0';

            int carry = 1;
            for (int i = 31; i >= 0; i--)
            {
                if (inverted[i] == '1' && carry == 1)
                {
                    inverted[i] = '0';
                }
                else if (carry == 1)
                {
                    inverted[i] = '1';
                    carry = 0;
                }
            }
            return -(Convert.ToInt32(new string(inverted), 2) + (carry == 1 ? 1 : 0));
        }
        else
        {
            return Convert.ToInt32(binary, 2);
        }
    }
}