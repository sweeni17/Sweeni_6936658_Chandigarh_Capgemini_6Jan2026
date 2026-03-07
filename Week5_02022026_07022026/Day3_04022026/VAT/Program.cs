using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter Product Type (M/V/C/D):");
        char product = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter Product Price:");
        double price = Convert.ToDouble(Console.ReadLine());

        double vatRate = 0;

        switch (product)
        {
            case 'M':
                vatRate = 5;
                break;

            case 'V':
                vatRate = 12;
                break;

            case 'C':
                vatRate = 6.25;
                break;

            case 'D':
                vatRate = 6;
                break;

            default:
                Console.WriteLine("Invalid Product Type");
                return;
        }

        double vatAmount = (price * vatRate) / 100;
        double totalAmount = price + vatAmount;

        Console.WriteLine("VAT Percentage: " + vatRate + "%");
        Console.WriteLine("VAT Amount: " + vatAmount);
        Console.WriteLine("Total Amount (Including VAT): " + totalAmount);
    }
}
