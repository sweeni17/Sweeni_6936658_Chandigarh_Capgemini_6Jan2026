namespace Sum_of_cube_of_prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int input1 = int.Parse(Console.ReadLine());
            int output = 0;

            if (input1 < 0)
            {
                output = -1;
            }
            else if (input1 > 32767)
            {
                output = -2;
            }
            else
            {
                for (int i = 2; i <= input1; i++)
                {
                    int count = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }

                    if (count == 2)
                    {
                        output += i * i * i;
                    }
                }
            }

            Console.WriteLine(output);
        }
    }
}
