using System;
using System.Linq;

class Program
{
    static bool IsPalindrome(string s)
    {
        return s.SequenceEqual(s.Reverse());
    }

    static void Main()
    {
        string str = "ABCBAAAA";
        int score = 0;

        for (int i = 0; i <= str.Length - 4; i++)
            if (IsPalindrome(str.Substring(i, 4)))
                score += 5;

        for (int i = 0; i <= str.Length - 5; i++)
            if (IsPalindrome(str.Substring(i, 5)))
                score += 10;

        Console.WriteLine(score);
    }
}
