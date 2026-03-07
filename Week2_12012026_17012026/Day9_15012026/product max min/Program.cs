namespace product_max_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array: ");
            int Input2 = int.Parse(Console.ReadLine());
            if (Input2 < 0)
            {
                Console.WriteLine("Output: -2");
            }
            Console.WriteLine("Enter array elements: ");
            int[] Input1 = new int[Input2];
            for (int i = 0; i < Input2; i++)
            {
                Input1[i] = int.Parse(Console.ReadLine());
                if (Input1[i] < 0)
                {
                    Console.WriteLine("Output: -1");
                }
            }
            int Output;
            Array.Sort(Input1);
            Output = Input1[0] * Input1[Input2 - 1];
            Console.WriteLine("Output: " + Output);
        }
    }
}
