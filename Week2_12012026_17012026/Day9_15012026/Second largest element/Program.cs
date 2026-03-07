namespace Second_largest_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int Input3 = int.Parse(Console.ReadLine());
            if (Input3 < 0)
            {
                Console.WriteLine("Output: -2");
            }

            Console.WriteLine("Enter first Array: ");
            int[] Input1 = new int[Input3];
            for (int i = 0; i < Input3; i++)
            {
                Input1[i] = int.Parse(Console.ReadLine());
                if (Input1[i] < 0)
                {
                    Console.WriteLine("Output: -1");
                }
            }

            Array.Sort(Input1);
            int Output1 = Input1[Input3 - 2];
            Console.WriteLine("Output: " + Output1);
        }
    }
}
