namespace sum_of_multiples_upto_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int Num = int.Parse(Console.ReadLine());
            if (Num < 0)
            {
                Console.WriteLine("-1");
            }

            Console.WriteLine("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            if (N > 32627)
            {
                Console.WriteLine("-2");
            }

            int sum = 0;
            for (int i = 0; i <= N; i++)
            {
                if (i%Num == 0)
                {
                    sum = sum + i;
                }

            }
            Console.WriteLine("Sum of multiples of " + Num + " is: " + sum);
        }
    }
}
