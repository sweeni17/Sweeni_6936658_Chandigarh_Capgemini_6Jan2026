namespace Add_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 21, 23, 41, 4 };
            int[] input2 = { 3, 4, 1, 5 };
            int input3 = 4;

            int[] output = new int[input3];

            // BR-2: If array size is negative
            if (input3 < 0)
            {
                output = new int[] { -2 };
            }
            else
            {
                // BR-1: Check for negative elements
                for (int i = 0; i < input3; i++)
                {
                    if (input1[i] < 0 || input2[i] < 0)
                    {
                        output[0] = -1;
                        PrintArray(output);
                        return;
                    }
                }

                // Add elements index-wise
                for (int i = 0; i < input3; i++)
                {
                    output[i] = input1[i] + input2[i];
                }
            }

            PrintArray(output);
        }

        static void PrintArray(int[] arr)
        {
            Console.Write("OUTPUT = { ");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("}");
        }
    }
}
