using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        int result = CountValidWords(input);

        Console.WriteLine("Number of Valid Words: " + result);
    }

    public static int CountValidWords(string input)
    {
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int validCount = 0;

        foreach (string word in words)
        {
            if (IsValidWord(word))
            {
                validCount++;
            }
        }

        return validCount;
    }

    private static bool IsValidWord(string word)
    {
        if (word.Length <= 2)
            return false;

        bool hasVowel = false;
        bool hasConsonant = false;

        foreach (char c in word)
        {
            // Check if alphanumeric
            if (!char.IsLetterOrDigit(c))
                return false;

            if (char.IsLetter(c))
            {
                char lower = char.ToLower(c);

                if ("aeiou".Contains(lower))
                    hasVowel = true;
                else
                    hasConsonant = true;
            }
        }

        return hasVowel && hasConsonant;
    }
}
