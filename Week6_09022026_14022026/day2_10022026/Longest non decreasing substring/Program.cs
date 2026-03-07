using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter binary string:");
        string s = Console.ReadLine();

        int count00 = 0, count01 = 0, count10 = 0, count11 = 0;

        for (int i = 0; i < s.Length - 1; i += 2)
        {
            string block = s.Substring(i, 2);

            if (block == "00") count00++;
            else if (block == "01") count01++;
            else if (block == "10") count10++;
            else if (block == "11") count11++;
        }

        int zerosPart = 2 * count00 + count01;
        int onesPart = 2 * count11 + count01;

        int result = zerosPart + onesPart;

        // Edge case: if all blocks are "10"
        if (result == 0 && count10 > 0)
            result = 1;

        Console.WriteLine("Longest Non-Decreasing Substring Length: " + result);
    }
}
