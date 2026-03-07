using System.Xml;

namespace Sum_of_squares_of_odd_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("-1");
            }
            int digit = 0;
            int Output = 0;
            while (num > 0)
            {
                digit = num % 10;
                if (digit % 2 != 0)
                {
                    Output += (digit * digit);
                }
               
                    num = num / 10;
                
                
            }
            Console.WriteLine("Sum of squares of odd digits: " + Output);
        }
    }
}
