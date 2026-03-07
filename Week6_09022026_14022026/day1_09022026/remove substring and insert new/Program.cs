namespace remove_substring_and_insert_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "HelloWorld";
            int pos = s.IndexOf("World");

            s = s.Remove(pos, "World".Length)
                 .Insert(pos, "Universe");

            Console.WriteLine(s);

        }
    }
}
