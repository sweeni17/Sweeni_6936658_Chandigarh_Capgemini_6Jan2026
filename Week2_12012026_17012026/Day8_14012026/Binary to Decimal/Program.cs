namespace Binary_to_Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Binary Number: ");
            int Input = int.Parse(Console.ReadLine());
            int Output = 0;
            if (Input > 11111)
            {
                Output = -2;
                Console.WriteLine(Output);
                return;
            }
            int digit = 0;
            int Power = 1;
            while (Input > 0)
            {
                digit = Input % 10;
                if (digit != 0 && digit != 1)
                {
                    Output = -1;
                    Console.WriteLine(Output);
                    break;
                }
                Output += (digit * Power);
                Power *= 2;
                Input = Input / 10;
            }
            Console.WriteLine("Decimal: "+ Output);
        }
    }
}
