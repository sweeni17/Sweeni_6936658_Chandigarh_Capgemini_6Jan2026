using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter employee skills (space separated):");
        int[] skills = Console.ReadLine()
                              .Split()
                              .Select(int.Parse)
                              .ToArray();

        Console.WriteLine("Enter team sizes (space separated):");
        int[] teamSizes = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

        long result = MaxTotalStrength(skills, teamSizes);

        Console.WriteLine("Maximum Total Team Strength: " + result);
    }

    public static long MaxTotalStrength(int[] skills, int[] teamSizes)
    {
        Array.Sort(skills);

        Array.Sort(teamSizes);
        Array.Reverse(teamSizes); // sort team sizes in descending order

        int left = 0;
        int right = skills.Length - 1;

        long totalStrength = 0;

        foreach (int size in teamSizes)
        {
            int max = skills[right--];
            int min = skills[left];

            totalStrength += max + min;

            left += size - 1;
        }

        return totalStrength;
    }
}
