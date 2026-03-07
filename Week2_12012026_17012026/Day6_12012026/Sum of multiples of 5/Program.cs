namespace Sum_of_multiples_of_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int input2 = int.Parse(Console.ReadLine());

            int output;

            if (input2 < 0)
            {
                output = -2;
                Console.WriteLine("Output = " + output);
                return;
            }

            int[] input1 = new int[input2];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < input2; i++)
            {
                input1[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int count = 0;

            for (int i = 0; i < input2; i++)
            {
                if (input1[i] < 0)
                {
                    output = -1;
                    Console.WriteLine("Output = " + output);
                    return;
                }

                if (input1[i] % 5 == 0)
                {
                    sum += input1[i];
                    count++;
                }
            }

            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine("Sum = " + sum);
                Console.WriteLine("Average = " + average);
            }
            else
            {
                Console.WriteLine("Sum = 0");
                Console.WriteLine("Average = 0");
            }
        }
    }
}