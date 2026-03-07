using System;
using System.Collections.Generic;
using System.Text;

namespace Count_of_Elements
{
    internal class UserProgramCode
    {
        public static int GetCount(int size, string[] input1, char input2)
        {
            int count = 0;
            foreach(string s in input1)
            {
                foreach(char c in s)
                {
                    if (!char.IsLetter(c))
                    {
                        return -2;
                    }
                }
                if (char.ToLower(s[0]) == char.ToLower(input2))
                {
                    count++;
                }
            }
            if (count == 0)
            {
                return -1;
            }
            return count;
        }
    }
}
