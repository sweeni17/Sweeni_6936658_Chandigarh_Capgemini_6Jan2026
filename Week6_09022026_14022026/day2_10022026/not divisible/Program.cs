using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter array elements (comma-separated): ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(','),
                                     x => int.Parse(x.Trim()));

        int count = 0;
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            bool divisible = false;

            for (int j = 0; j < n; j++)
            {
                if (i != j && arr[j] != 0)
                {
                    if (arr[i] % arr[j] == 0)
                    {
                        divisible = true;
                        break;
                    }
                }
            }

            if (!divisible)
                count++;
        }

        Console.WriteLine(count);
    }
}
