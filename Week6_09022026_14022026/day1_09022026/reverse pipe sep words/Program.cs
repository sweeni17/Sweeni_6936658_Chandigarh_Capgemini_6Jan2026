namespace reverse_pipe_sep_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "A|B|C|D";
            string[] arr = input.Split('|');
            Array.Reverse(arr);
            Console.WriteLine(string.Join("|", arr));

        }
    }
}
