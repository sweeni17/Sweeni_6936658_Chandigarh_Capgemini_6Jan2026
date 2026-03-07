namespace SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("ENter size of arrays: ");
            size = int.Parse(Console.ReadLine());

            int[] output;
            if (size < 0)
            {
                output = new int[1];
                output[0] = -2;
                Console.WriteLine(output[0]);
                return;
            }

            int[] input1 = new int[size];
            int[] input2 = new int[size];
            output = new int[size];

            Console.WriteLine("Enter elements of first array: ");
            for (int i = 0; i < size; i++)
            {
                input1[i] = int.Parse(Console.ReadLine());
                if (input1[i] < 0)
                {
                    output[0] = -1;
                    Console.WriteLine(output[0]);
                    return;
                }
            }

            Console.WriteLine("Enter elements of second array: ");
            for (int i = 0; i < size; i++)
            {
                input2[i] = int.Parse(Console.ReadLine());
                if (input2[i] < 0)
                {
                    output[0] = -1;
                    Console.WriteLine(output[0]);
                    return;
                }
            }

            Array.Sort(input1);
            Array.Sort(input2);
            Array.Reverse(input2);

            for (int i = 0; i < size; i++)
            {
                output[i] = input1[i] * input2[size - 1 - i];
            }

            Console.WriteLine("Output Array: ");
            for (int i = 0;i < size; i++)
            {
                Console.Write(output[i] + " ");
            }
        }
    }
}
