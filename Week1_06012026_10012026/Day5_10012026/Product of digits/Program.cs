namespace Product_of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = 56;
            int output;

            if (input1 < 0)
            {
                output = -1;
            }
            else if (input1 % 3 == 0 || input1 % 5 == 0)
            {
                output = -2;
            }
            else
            {
                int product = 1;
                int temp = input1;

                while (temp > 0)
                {
                    int digit = temp % 10;
                    product *= digit;
                    temp /= 10;
                }

                if (product % 3 == 0 || product % 5 == 0)
                    output = 1;
                else
                    output = 0;
            }

            Console.WriteLine("Output = " + output);
        }
    }
}
