namespace Armstrong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int output1 = 0;
            int sum = 0;
            int temp, digit;
            int digits = 0;

            Console.WriteLine("Enter number: ");
            n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                output1 = -1;
            }

            else if (n > 999)
            {
                output1 = -2;
            }

            else
            {
                temp = n;
                while (temp > 0)
                {

                    digits++;
                    temp /= 10;
                }

                temp = n;
                while (temp > 0)
                {
                    digit = temp % 10;
                    sum += (int)Math.Pow(digit, digits);
                    temp /= 10;
                }

                if (sum == n)
                {
                    output1 = 1;
                }
                else
                {
                    output1 = 0;
                }
            }
            Console.WriteLine(output1);
        }
    }
}
