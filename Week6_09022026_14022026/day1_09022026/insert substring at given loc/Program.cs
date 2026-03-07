namespace insert_substring_at_given_loc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "C programming";
            string insert = "ABC";
            int pos = 3;

            Console.WriteLine(s.Insert(pos, insert));

        }
    }
}
