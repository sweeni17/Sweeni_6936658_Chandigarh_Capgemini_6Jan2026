namespace Savings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of days worked for: ");
            int Input2 = int.Parse(Console.ReadLine());
            int Output1;
            Console.WriteLine("Enter salary: ");
            int Input1 = int.Parse(Console.ReadLine());

            if (Input2 < 0)
            {
                Output1 = -4;
                Console.WriteLine(Output1);
                return;
            }
            
            if (Input2 == 31)
            {
                Input1 = Input1 + 500;
            }

            if (Input1 > 9000)
            {
                Output1 = -1;
                Console.WriteLine(Output1);
            }

            if (Input1 < 0)
            {
                Output1 = -2;
                Console.WriteLine(Output1);
            }

            Output1 = (int)(Input1 - (0.5 * Input1) - (0.2 * Input1));
            Console.WriteLine("Savings: " + Output1);
        }
    }
}
