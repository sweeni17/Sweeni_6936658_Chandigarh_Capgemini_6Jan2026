using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter array elements (space separated):");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.WriteLine("Enter value of d:");
        int d = int.Parse(Console.ReadLine());

        int count = CountTriplets(arr, d);

        Console.WriteLine("Triplet Count: " + count);
    }

    public static int CountTriplets(int[] arr, int d)
    {
        int n = arr.Length;
        int count = 0;

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = i + 1; j < n - 1; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if ((arr[i] + arr[j] + arr[k]) % d == 0)
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }
}
