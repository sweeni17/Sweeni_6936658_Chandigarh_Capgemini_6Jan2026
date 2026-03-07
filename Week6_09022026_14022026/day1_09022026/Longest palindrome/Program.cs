using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string s = "babad";
        int maxLen = 1;

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i; j < s.Length; j++)
            {
                string sub = s.Substring(i, j - i + 1);
                if (sub.SequenceEqual(sub.Reverse()))
                    maxLen = Math.Max(maxLen, sub.Length);
            }
        }
        Console.WriteLine(maxLen);
    }
}
