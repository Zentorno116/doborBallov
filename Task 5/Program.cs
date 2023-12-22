using System;
using System.Linq;

public static class Program
{
    public static void Main()
    {
        Console.Write("Введите количество массивов: ");
        int numArrays = int.Parse(Console.ReadLine());

        for (int i = 0; i < numArrays; i++)
        {
            Console.Write($"Введите количество элементов в массиве {i + 1}: ");
            int numElements = int.Parse(Console.ReadLine());

            int[] arr = new int[numElements];
            for (int j = 0; j < numElements; j++)
            {
                Console.Write($"Введите элемент {j + 1} массива {i + 1}: ");
                arr[j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ближайшее к нулю значение: " + ClosestToZero(arr));
        }
    }

    public static int? ClosestToZero(int[] arr)
    {
        var grouped = arr.GroupBy(x => Math.Abs(x)).OrderBy(x => x.Key);
        return grouped.First().Count() == 1 ? (int?)grouped.First().First() : null;
    }
}
