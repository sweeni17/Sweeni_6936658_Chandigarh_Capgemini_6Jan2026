namespace Reverse_string
{
    internal class Program
    {
        public static string ReverseString(string input)
        {
            char[] str = input.ToCharArray();
            int l = 0;
            int r = input.Length -1;
            while (l < r)
            {
                char temp = str[l];
                str[l] = str[r];
                str[r] = temp;
                l++;
                r--;
            }
            return new string(str);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string result = Console.ReadLine();
            Console.WriteLine("result: " + ReverseString(result));
        }
    }
}
