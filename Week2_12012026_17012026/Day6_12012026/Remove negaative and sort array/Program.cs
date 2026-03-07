namespace Remove_negaative_and_sort_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int input2 = int.Parse(Console.ReadLine());

            if (input2 < 0)
            {
                Console.WriteLine("Output = -1");
                return;
            }

            int[] input1 = new int[input2];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < input2; i++)
            {
                input1[i] = int.Parse(Console.ReadLine());
            }

            int[] temp = new int[input2];
            int count = 0;

            for (int i = 0; i < input2; i++)
            {
                if (input1[i] >= 0)
                {
                    temp[count] = input1[i];
                    count++;
                }
            }

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (temp[i] > temp[j])
                    {
                        int swap = temp[i];
                        temp[i] = temp[j];
                        temp[j] = swap;
                    }
                }
            }

            int[] output = new int[count];
            for (int i = 0; i < count; i++)
            {
                output[i] = temp[i];
            }

            PrintArray(output);
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
