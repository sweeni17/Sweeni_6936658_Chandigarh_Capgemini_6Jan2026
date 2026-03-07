namespace Sum_of_Prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 2, 3, 4, 5 };
            int input2 = 5;
            int output1;

            if (input2 < 0)
            {
                output1 = -2;
            }
            else
            {
                int sum = 0;
                bool hasPrime = false;

                for (int i = 0; i < input2; i++)
                {
                    if (input1[i] < 0)
                    {
                        output1 = -1;
                        Console.WriteLine("Output = " + output1);
                        return;
                    }

                    int num = input1[i];

                    if (num > 1)
                    {
                        bool isPrime = true;

                        for (int j = 2; j <= num / 2; j++)
                        {
                            if (num % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        if (isPrime)
                        {
                            sum += num;
                            hasPrime = true;
                        }
                    }
                }

                if (!hasPrime)
                    output1 = -3;
                else
                    output1 = sum;
            }

            Console.WriteLine("Output = " + output1);
        }
    }
}
