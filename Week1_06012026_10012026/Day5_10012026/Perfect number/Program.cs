namespace Perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = 6;
            int output;

            if (input1 < 0)
            {
                output = -2;
            }
            else
            {
                int sum = 0;

                for (int i = 1; i <= input1 / 2; i++)
                {
                    if (input1 % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == input1)
                    output = 1; 
                else
                    output = -1; 
            }

            Console.WriteLine("Output = " + output);
        }
    }
}
