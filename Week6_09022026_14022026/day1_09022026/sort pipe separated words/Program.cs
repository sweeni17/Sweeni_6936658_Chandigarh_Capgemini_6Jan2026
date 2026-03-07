namespace sort_pipe_separated_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "dog|cat|apple";
            string[] words = input.Split('|');
            Array.Sort(words);
            Console.WriteLine(string.Join("|", words));

        }
    }
}
