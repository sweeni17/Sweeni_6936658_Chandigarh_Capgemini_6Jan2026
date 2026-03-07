using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter array elements (comma-separated): ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(','),
                                     x => int.Parse(x.Trim()));

        int score = 0;
        int n = arr.Length;

        // Check Couples
        for (int i = 0; i < n - 1; i++)
        {
            int sum = arr[i] + arr[i + 1];

            if (sum % 2 == 0)
                score += 5;
        }

        // Check Triplets
        for (int i = 0; i < n - 2; i++)
        {
            int sum = arr[i] + arr[i + 1] + arr[i + 2];
            int product = arr[i] * arr[i + 1] * arr[i + 2];

            if (sum % 2 != 0 && product % 2 == 0)
                score += 10;
        }

        Console.WriteLine("Final Score: " + score);
    }
}
