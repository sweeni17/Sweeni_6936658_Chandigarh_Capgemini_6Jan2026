namespace Sum_of_cubes_of_prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n value: ");
            int n = int.Parse(Console.ReadLine());

            int output;

            if (n < 0)
            {
                output = -1;
            }
            else if (n > 32676)
            {
                output = -2;
            }
            else
            {
                int sum = 0;

                for (int num = 2; num <= n; num++)
                {
                    bool isPrime = true;

                    for (int i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        sum += num * num * num; 
                    }
                }

                output = sum;
            }

            Console.WriteLine("Output = " + output);
        }
    }
}
