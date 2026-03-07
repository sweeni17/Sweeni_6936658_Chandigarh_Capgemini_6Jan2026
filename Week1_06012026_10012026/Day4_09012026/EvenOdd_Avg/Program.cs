namespace EvenOdd_Avg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            double output1 = 0;
            int evensum = 0, oddsum = 0;

            Console.WriteLine("Enter Array Size");
            size = int.Parse(Console.ReadLine());

            if (size < 0)
            {
                output1 = -2;
            }
            else
            {
                int[] array = new int[size];
                Console.WriteLine("Enter Array Elements: ");
                for (int i = 0; i < size; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                    if (array[i] < 0)
                    {
                        output1 = -1;
                        Console.WriteLine(output1);
                        return;
                    }

                    if (array[i] % 2 == 0)
                    {
                        evensum += array[i];
                    }
                    else
                    {
                        oddsum += array[i];
                    }

                    output1 = (evensum + oddsum) / 2.0;
                }
                Console.WriteLine("Average of Even and Odd Elements is: " + output1);
            }

        }
    }
}
