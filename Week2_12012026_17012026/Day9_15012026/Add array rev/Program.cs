namespace Add_array_rev
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
            for (int i = 0; i<Input3;  i++)
            {
                Input1[i] = int.Parse(Console.ReadLine());
                if (Input1[i] < 0)
                {
                    Console.WriteLine("Output: -1");
                }
            }

            Console.WriteLine("Enter second Array: ");
            int[] Input2 = new int[Input3];
            for (int i = 0; i < Input3; i++)
            {
                Input2[i] = int.Parse(Console.ReadLine());
                if (Input2[i] < 0)
                {
                    Console.WriteLine("Output: -1");
                }
            }

            int[] Output = new int[Input3];

            for (int i = 0; i< Input3; i++)
            {
                Output[i]= Input1[i] + Input2[Input3 -1 -i];
            }
            Console.WriteLine("Output: ");
            for(int i = 0; i< Input3; i++)
            {
                Console.WriteLine(Output[i]);
            }
        }
    }
}
