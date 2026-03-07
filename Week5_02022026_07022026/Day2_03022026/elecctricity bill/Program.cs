using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string input1 = Console.ReadLine();   // First meter reading
        string input2 = Console.ReadLine();   // Second meter reading
        int rate = int.Parse(Console.ReadLine());  // Rate per unit

        // Extract numeric part
        string num1Str = new string(input1.Where(char.IsDigit).ToArray());
        string num2Str = new string(input2.Where(char.IsDigit).ToArray());

        int reading1 = int.Parse(num1Str);
        int reading2 = int.Parse(num2Str);

        int difference = Math.Abs(reading1 - reading2);

        int billAmount = difference * rate;

        Console.WriteLine(billAmount);
    }
}
