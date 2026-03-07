namespace Longest_substring_without_repeating_characters
{
    internal class Program
    {
        public static int Substring(string s)
        {
            
            Dictionary<char,int> map = new Dictionary<char,int>();

            int maxCount = 0;
            int l = 0;
            for (int right = 0; right < s.Length; right++)
            {
                if (map.ContainsKey(s[right]) && map[s[right]] >= 1) {
                    l= map[s[right]] +1;
                }
                else
                {
                    map[s[right]] = right;
                    maxCount = Math.Max(maxCount, right - l + 1);
                }
            }
            return maxCount;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            string st1 = Console.ReadLine();
            Console.WriteLine("Longest Substring: " + Substring(st1));
        }
    }
}
