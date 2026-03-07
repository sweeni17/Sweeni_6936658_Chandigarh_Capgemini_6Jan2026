using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string invoice = Console.ReadLine();   // e.g., CAP-123
        int increment = int.Parse(Console.ReadLine());  // e.g., 7

        string pattern = @"^CAP-(\d+)$";

        Match match = Regex.Match(invoice, pattern);

        if (match.Success)
        {
            // Extract numeric part
            int currentNumber = int.Parse(match.Groups[1].Value);

            // Add increment
            int newNumber = currentNumber + increment;

            // Create updated invoice
            string updatedInvoice = "CAP-" + newNumber;

            Console.WriteLine(updatedInvoice);
        }
        else
        {
            Console.WriteLine("Invalid Invoice Format");
        }
    }
}
