using System.Xml;

namespace Avg_divisible_by_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array size: ");
            int Input2 = int.Parse(Console.ReadLine());
            if (Input2 < 0)
            {
                Console.WriteLine("-1");
            }
            Console.WriteLine("Enter elements of array: ");
            int[] Input1 = new int[Input2];

            for (int i = 0; i < Input2; i++)
            {
                Input1[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0, count = 0;
            int Output;
            for(int i = 0; i < Input2; i++)
            {
                if (Input1[i] % 5 == 0)
                {
                    sum += Input1[i];
                    count++;
                }
            }

            Output = sum / count;
            Console.WriteLine("Average of numbers divisible by 5 is: " + Output);
        }
    }
}
