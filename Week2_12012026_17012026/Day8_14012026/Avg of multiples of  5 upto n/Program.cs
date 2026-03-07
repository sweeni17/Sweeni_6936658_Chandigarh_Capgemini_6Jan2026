using System.Xml;

namespace Avg_of_multiples_of__5_upto_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a natural number: ");
            int Input1 = int.Parse(Console.ReadLine());

            if (Input1 < 0)
            {
                Console.WriteLine("-1");
            }
            else if (Input1 > 500)
            {
                Console.WriteLine("-2");
            }
            int sum = 0, count = 0;
            int Output = 0;
            for (int i = 1; i <= Input1; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                    count++;
                }
            }
            Output = sum / count;
            Console.WriteLine("Average of multiples of 5 upto " + Input1 + " is: " + Output);
        }
    }
}
