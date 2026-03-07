namespace Leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 ==  0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }
        }
    }
}
