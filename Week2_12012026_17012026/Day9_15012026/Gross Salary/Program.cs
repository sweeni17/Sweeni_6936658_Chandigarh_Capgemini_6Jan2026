using System.Buffers.Text;

namespace Gross_Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base Salary: ");
            int Base = int.Parse(Console.ReadLine());

            if (Base < 0)
            {
                Console.WriteLine("Output: -1");
                return;
            }

            if (Base > 10000)
            {
                Console.WriteLine("Output: -2");
                return;
            }

            Console.WriteLine("Enter number of working days: ");
            int Days = int.Parse(Console.ReadLine());   
            if (Days >31)
            {
                Console.WriteLine("Output: -3");
            }

            double Gross = Base + (Base * 75 / 100 ) + (Base * 0.50);
            Console.WriteLine("Output: " + Gross);
        }
    }
}
