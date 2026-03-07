using System.Text;

namespace Alphabets_and_Vowels
{
    class Program
    {
        public static bool IsVowel(char c)
        {
            c = char.ToLower(c);
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }

        public static string RemoveCommon(string word1, string word2)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < word1.Length; i++)
            {
                char c1 = word1[i];
                char lowerc1 = char.ToLower(c1);

                if (IsVowel(lowerc1))
                {
                    result.Append(c1);
                }
                else
                {
                    bool found = false;
                    for (int j = 0; j < word2.Length; j++)
                    {
                        if (char.ToLower(word2[j]) == lowerc1)
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        result.Append(c1);
                    }
                }
            }
            return result.ToString();
        }

        public static string RemoveDup(string input)
        {
            if (input.Length == 0)
            {
                return input;
            }

            StringBuilder result = new StringBuilder();
            result.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (char.ToLower(input[i]) != char.ToLower(input[i - 1]))
                {
                    result.Append(input[i]);
                }
            }
            return result.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter second word: ");
            string word2 = Console.ReadLine();

            string word3 = RemoveCommon(word1, word2);
            string final = RemoveDup(word3);
            Console.WriteLine(final);
        }
    }
}
