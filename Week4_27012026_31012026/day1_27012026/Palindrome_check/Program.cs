namespace Palindrome_check
{
    internal class Program
    {
        public static bool Palindrome(string input)
        {
            int i = 0;
            int j = input.Length -1 ;
            while (i < j)
            {
                if (input [i] != input[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine(Palindrome(str));
        }
    }
}
