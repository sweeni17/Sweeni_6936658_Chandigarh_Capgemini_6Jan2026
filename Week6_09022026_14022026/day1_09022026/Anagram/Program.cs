using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter comma separated words: ");
        string input = Console.ReadLine();

        string[] words = input.Split(',');

        string sortedBase = String.Concat(words[0].Trim().OrderBy(c => c));

        bool isAnagram = true;

        for (int i = 1; i < words.Length; i++)
        {
            string sortedWord = String.Concat(words[i].Trim().OrderBy(c => c));
            if (sortedWord != sortedBase)
            {
                isAnagram = false;
                break;
            }
        }

        Console.WriteLine(isAnagram);
    }
}
