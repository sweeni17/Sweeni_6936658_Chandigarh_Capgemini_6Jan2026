using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the first list of integers (comma-separated): ");
        int[] firstList = Console.ReadLine()
                                 .Split(',')
                                 .Select(x => int.Parse(x.Trim()))
                                 .ToArray();

        Console.Write("Enter the second list of integers (comma-separated): ");
        int[] secondList = Console.ReadLine()
                                  .Split(',')
                                  .Select(x => int.Parse(x.Trim()))
                                  .ToArray();

        // Store frequency sum using Dictionary
        Dictionary<int, int> sumMap = new Dictionary<int, int>();

        foreach (int num in secondList)
        {
            if (sumMap.ContainsKey(num))
                sumMap[num] += num;
            else
                sumMap[num] = num;
        }

        // Print result
        foreach (int n in firstList)
        {
            int sum = sumMap.ContainsKey(n) ? sumMap[n] : 0;
            Console.WriteLine(n + "-" + sum);
        }
    }
}
