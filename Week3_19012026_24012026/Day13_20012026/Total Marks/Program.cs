namespace Total_Marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y");
            int Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n2");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter M");
            int M = int.Parse(Console.ReadLine());

            bool found = false;

            for (int a = n1; a >= 0; a--)
            {
                int remaining = M - (a * X);

                if (remaining < 0)
                    continue;

                if (remaining % Y == 0)
                {
                    int b = remaining / Y;

                    if (b <= n2)
                    {
                        Console.WriteLine("Valid");
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
