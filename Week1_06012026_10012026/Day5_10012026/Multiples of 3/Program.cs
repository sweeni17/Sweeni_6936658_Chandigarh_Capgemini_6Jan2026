namespace Multiples_of_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 2, 3, 4, 5, 6 };
            int input2 = 6;   
            int output;

            if (input2 < 0)
            {
                output = -2;
            }
            else
            {
                bool hasNegative = false;
                int count = 0;

                for (int i = 0; i < input2; i++)
                {
                    if (input1[i] < 0)
                    {
                        hasNegative = true;
                        break;
                    }

                    if (input1[i] % 3 == 0)
                    {
                        count++;
                    }
                }

                if (hasNegative)
                    output = -1;
                else
                    output = count;
            }

            Console.WriteLine("Output = " + output);
        }
    }
}
