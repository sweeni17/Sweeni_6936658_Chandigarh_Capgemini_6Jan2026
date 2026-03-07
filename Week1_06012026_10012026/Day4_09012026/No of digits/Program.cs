namespace No_of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int output1;
            int digit = 0;
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                output1 = -1;
            }
            else
            {
                while (number > 0)
                {
                    digit++;
                    number /= 10;
                }
                output1 = digit;

            }
            Console.WriteLine("Number of digits: " + output1);
        }
    }
}
