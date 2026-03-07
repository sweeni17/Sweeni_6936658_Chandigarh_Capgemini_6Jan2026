namespace MultiplyPositive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            int output = 1;

            Console.WriteLine("Enter array size:");
            size = int.Parse(Console.ReadLine());

            if (size < 0)
            {
                output = -2;
                Console.WriteLine(output);
                return;
            }

            int[] array = new int[size];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                if (array[i] > 0)
                {
                    output *= array[i];
                }
            }

            Console.WriteLine("Output: " + output);
        }
    }
}
