using System.Xml;

namespace String_Compression
{
    internal class Program
    {
        public static string CompressString(string s)
        {
            char[] chars = s.ToCharArray();
            int idx = 0;
            int n = chars.Length;

            for (int i = 0; i < n; i++)
            {
                char ch = chars[i];
                int count = 0;
                while (i < n && chars[i] == ch)
                {
                    count++;
                    i++;
                }
                if (count == 1)
                {
                    chars[idx++] = ch;
                }
                if (count>1)
                {
                    chars[idx++] = ch;
                    string st = count.ToString();
                    foreach (char c in st)
                    {
                        chars[idx++] = c;
                    }
                }
                i--;
            }
            Array.Resize(ref chars,idx);
            return new string (chars);
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Compressed String: " + CompressString(s1));
        }
    }
}
