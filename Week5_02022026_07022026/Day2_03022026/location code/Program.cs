using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string invoice = Console.ReadLine();       // e.g., CAP-HYD-1234
        string newLocation = Console.ReadLine();   // e.g., BAN

        string pattern = @"^CAP-([A-Z]{3})-(\d+)$";

        Match match = Regex.Match(invoice, pattern);

        if (match.Success)
        {
            string numberPart = match.Groups[2].Value;

            string updatedInvoice = $"CAP-{newLocation}-{numberPart}";

            Console.WriteLine(updatedInvoice);
        }
        else
        {
            Console.WriteLine("Invalid Invoice Format");
        }
    }
}
