using System;


class Program
{
    static void Main()
    {
        int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        int[] squaredArray = originalArray.Square();
        int[] cubedArray = originalArray.Cube();
        double averageValue = originalArray.Average();
        int sumValue = originalArray.Sum();
        int[] evenArray = originalArray.Even();
        int[] oddArray = originalArray.Odd();

        Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
        Console.WriteLine("Squared Array: " + string.Join(", ", squaredArray));
        Console.WriteLine("Cubed Array: " + string.Join(", ", cubedArray));
        Console.WriteLine("Average Value: " + averageValue);
        Console.WriteLine("Sum Value: " + sumValue);
        Console.WriteLine("Even Numbers: " + string.Join(", ", evenArray));
        Console.WriteLine("Odd Numbers: " + string.Join(", ", oddArray));
    }
}
