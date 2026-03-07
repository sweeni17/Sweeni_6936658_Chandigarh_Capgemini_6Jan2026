namespace Count_Vowels
{
    internal class Program
    {
        public static int Count_vowels(string input)
        {
            int count = 0;
            char[] ch = input.ToCharArray();
            int i = 0;
            while (i < input.Length)
            {
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                {
                    count++;
                }
                i++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            Console.WriteLine("Number of vowels: " + Count_vowels(str));
        }
    }
}
