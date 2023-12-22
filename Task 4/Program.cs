using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string[] arr = new string[] { ":)", ":D", ";-D", ":~)", ";-)", ":)", ":D", ";D", ";~D", ";-)", ":)", ":D", ";D", ";~)", ";-)" };
        int count = CountSmileys(arr);
        Console.WriteLine("Number of smileys: " + count);
    }

    public static int CountSmileys(string[] arr)
    {
        return arr.Count(s => Regex.IsMatch(s,@"^[:;][-~]?[)D]$"));
    }
}
