namespace Remove_duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 2, 2, 3, 3 };
            int input2 = 5;

            if (input2 < 0)
            {
                int[] output = { -2 };
                PrintArray(output);
                return;
            }

            for (int i = 0; i < input2; i++)
            {
                if (input1[i] < 0)
                {
                    int[] output = { -1 };
                    PrintArray(output);
                    return;
                }
            }

            int[] temp = new int[input2];
            int count = 0;

            for (int i = 0; i < input2; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < count; j++)
                {
                    if (input1[i] == temp[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    temp[count] = input1[i];
                    count++;
                }
            }

            int[] output1 = new int[count];
            for (int i = 0; i < count; i++)
            {
                output1[i] = temp[i];
            }

            PrintArray(output1);
        }

        static void PrintArray(int[] arr)
        {
            Console.Write("Output = { ");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("}");
        }
    }
}
