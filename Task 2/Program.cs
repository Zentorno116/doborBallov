using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] arr = new string[] { "Telescopes", "Glasses", "Eyes", "Monocles" };
        string[] sortedArr = SortByLength(arr);
        foreach (string s in sortedArr)
        {
            Console.WriteLine(s);
            Console.ReadKey();
            Console.Clear();
        }
    }

    static string[] SortByLength(string[] arr)
    {
        return arr.OrderBy(s => s.Length).ToArray();
    }
}
