namespace Anagram_check
{
    internal class Program
    {
        static bool Anagram_check(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            char[] a1 = s1.ToLower().ToCharArray();
            char[] a2 = s2.ToLower().ToCharArray();

            Array.Sort(a1);
            Array.Sort(a2);

            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] == a2[i])
                {
                    return true;
                }

            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string 1: ");
            string st1 = Console.ReadLine();
            Console.WriteLine("Enter string 2: ");
            string st2 = Console.ReadLine();
            Console.WriteLine("Anagram: " + Anagram_check(st1, st2));
        }
    }
}
