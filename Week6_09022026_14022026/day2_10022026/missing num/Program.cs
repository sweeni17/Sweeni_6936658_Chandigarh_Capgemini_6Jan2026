using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter numbers (comma-separated): ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(','),
                                     x => int.Parse(x.Trim()));

        int n = arr.Length;

        int expectedSum = (n + 1) * (n + 2) / 2;
        int actualSum = arr.Sum();

        int missingNumber = expectedSum - actualSum;

        Console.WriteLine(missingNumber);
    }
}
