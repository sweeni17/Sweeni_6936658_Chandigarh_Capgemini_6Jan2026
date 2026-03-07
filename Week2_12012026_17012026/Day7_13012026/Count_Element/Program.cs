using System;

namespace Count_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int Input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements of array:");
            int[] Input1 = new int[Input2];

            for (int i = 0; i < Input2; i++)
            {
                Input1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the element to count: ");
            int Input3 = int.Parse(Console.ReadLine());

            int Output = Count_Element(Input1, Input2, Input3);
            Console.WriteLine("Output: " + Output);
        }

        static int Count_Element(int[] Input1, int Input2, int Input3)
        {
            if (Input2 < 0)
                return -2;

            if (Input3 < 0)
                return -3;

            int count = 0;

            for (int i = 0; i < Input2; i++)
            {
                if (Input1[i] < 0)
                    return -1;

                if (Input1[i] == Input3)
                    count++;
            }

            return count; 
        }
    }
}
