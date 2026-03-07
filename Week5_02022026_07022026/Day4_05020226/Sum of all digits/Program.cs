using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a positive integer (up to 10 digits):");

        long number = Convert.ToInt64(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        long temp = number;
        int sum = 0;

        while (temp > 0)
        {
            int digit = (int)(temp % 10);  // Extract last digit
            sum += digit;                 // Add to sum
            temp = temp / 10;             // Remove last digit
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}
