using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter first date (dd/MM/yyyy):");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter second date (dd/MM/yyyy):");
        string input2 = Console.ReadLine();

        // Define expected format
        string format = "dd/MM/yyyy";

        DateTime date1 = DateTime.ParseExact(input1, format, CultureInfo.InvariantCulture);
        DateTime date2 = DateTime.ParseExact(input2, format, CultureInfo.InvariantCulture);

        // Calculate difference
        TimeSpan difference = date2 - date1;

        Console.WriteLine(Math.Abs(difference.Days) + " days");
    }
}
