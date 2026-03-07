namespace Number_of_Multiples_of_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            int output;

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    output = -1;
                    Console.WriteLine("Output = " + output);
                    return;
                }

                if (arr[i] % 3 == 0)
                {
                    count++;
                }
            }

            output = count;
            Console.WriteLine("Output = " + output);
        }
    }
}
