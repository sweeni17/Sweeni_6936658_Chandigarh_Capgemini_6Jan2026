using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter full input:");
        string input = Console.ReadLine();

        string pattern = @"^Hi how are you Dear [A-Za-z]{16,}$";

        if (Regex.IsMatch(input, pattern))
        {
            Console.WriteLine("Valid pattern");
        }
        else
        {
            Console.WriteLine("Invalid pattern");
        }
    }
}
