using System.Xml;

namespace Remove_element_and_sort_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            
            int Input2 = int.Parse(Console.ReadLine());
            int[] Output = new int[Input2 - 1];
            if (Input2 < 0)
            {
                Output = new int[Input2];
                Console.WriteLine(Output);
            }

            Console.WriteLine("Enter array elements: ");
            int[] Input1 = new int[Input2];
            for (int i = 0; i < Input2; i++)
            {
                Input1[i] = int.Parse(Console.ReadLine());
                if (Input1[i] < 0)
                {
                    Output = new int[] { -1 };
                }

            }
            Console.WriteLine("Enter element to search:");
            int Input3 = int.Parse(Console.ReadLine());
            bool found = false;
            
            for (int i = 0; i < Input2; i++)
            {
                if(Input1[i] == Input3)
                {
                    found = true;
                    break;
                }

            }
            if (!found)
            {
                Output = new int[] { -3 };
            }
            int index = 0;
            for (int i = 0;i < Input2; i++)
            {
                if ( Input1[i] != Input3)
                {
                    Output[index++] = Input1[i];
                }
            }
            Array.Sort(Output);
            Console.WriteLine("Output: " + string.Join(", ", Output));
        }
    }
}
