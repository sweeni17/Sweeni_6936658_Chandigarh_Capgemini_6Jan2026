namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int Input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int Input2 = int.Parse(Console.ReadLine());

            if (Input1 < 0 && Input2 < 0)
            {
                Console.WriteLine("Output: -1");
            }
            Console.WriteLine("Enter Operation number:");
            int Input3 = int.Parse(Console.ReadLine());
            int Output;
            switch (Input3)
            {
                case 1:
                    Output = Input1 + Input2;
                    Console.WriteLine("Output: "+ Output);
                    break;

                case 2:
                    Output = Input1 - Input2;
                    Console.WriteLine("Output: "+ Output);
                    break;

                case 3:
                    Output = Input1 * Input2;
                    Console.WriteLine("Output: " + Output);
                    break;

                case 4:
                    Output = Input1 / Input2;
                    Console.WriteLine("Output: " + Output);
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
