namespace perfect_shuffle_of_2_sttrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static bool IsPerfectShuffle(string x, string y, string z)
            {
                if (x.Length + y.Length != z.Length) return false;

                int i = 0, j = 0;

                foreach (char c in z)
                {
                    if (i < x.Length && c == x[i]) i++;
                    else if (j < y.Length && c == y[j]) j++;
                    else return false;
                }
                return true;
            }

        }
    }
}
