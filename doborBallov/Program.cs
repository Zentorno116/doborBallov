using System;

class Program
{
    static void Main()
    {
        int n;
        while (true)
        {
            Console.Write("Введите длину ромба: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n) && n > 0 && n % 2 != 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введена неверная длина ромба. Длина должна быть положительным нечетным числом.");
            }
        }

        DrawDiamond(n);
        Console.ReadKey();
        Console.Clear();
    }

    static void DrawDiamond(int n)
    {
        for (int i = 0; i <= n / 2; i++)
        {
            Console.WriteLine(new string(' ', n / 2 - i) + new string('*', 2 * i + 1));
        }
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Console.WriteLine(new string(' ', n / 2 - i) + new string('*', 2 * i + 1));
        }
    }
}
