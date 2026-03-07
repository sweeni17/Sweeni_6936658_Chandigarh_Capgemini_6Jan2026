namespace Roman_to_Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Roman number: ");
            string input = Console.ReadLine();
            Console.WriteLine(UserProgramCode.ConvertRomanToDecimal(input));
        }
    }
}
