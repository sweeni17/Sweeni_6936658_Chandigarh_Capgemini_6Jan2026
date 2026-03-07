namespace Repeated_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] input1 = new int[size];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < size; i++)
            {
                input1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] < 0)
                {
                    int[] output = { -1 };
                    PrintArray(output);
                    return;
                }
            }

            int[] temp = new int[input1.Length];
            int count = 0;

            for (int i = 0; i < input1.Length; i++)
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
