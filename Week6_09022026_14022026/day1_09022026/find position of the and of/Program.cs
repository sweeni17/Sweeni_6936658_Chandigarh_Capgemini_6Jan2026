namespace find_position_of_the_and_of
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Console.WriteLine(line.IndexOf("the"));
            Console.WriteLine(line.IndexOf("of"));

        }
    }
}
