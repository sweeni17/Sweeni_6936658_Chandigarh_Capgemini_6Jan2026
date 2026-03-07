using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string password = Console.ReadLine();

        string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$";

        if (Regex.IsMatch(password, pattern))
        {
            Console.WriteLine("Strong");
        }
        else
        {
            Console.WriteLine("Weak");
        }
    }
}
