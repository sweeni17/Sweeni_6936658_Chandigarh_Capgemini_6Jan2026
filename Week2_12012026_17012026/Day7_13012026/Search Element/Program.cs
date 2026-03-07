namespace Search_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int Input2 = int.Parse(Console.ReadLine());

            int output;

            if (Input2 < 0)
            {
                output = -2;
            }
            else
            {
                int[] Input1 = new int[Input2];
                Console.WriteLine("Enter array elements:");

                for (int i = 0; i < Input2; i++)
                {
                    Input1[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter element to search:");
                int search = int.Parse(Console.ReadLine());

                output = SearchElement(Input1, Input2, search);
            }

            Console.WriteLine("Output: " + output);
        }

        static int SearchElement(int[] Input1, int Input2, int search)
        {
            for (int i = 0; i < Input2; i++)
            {
                if (Input1[i] < 0)
                    return -1;

                if (Input1[i] == search)
                    return 1;
            }

            return -3;
        }
    }
}
