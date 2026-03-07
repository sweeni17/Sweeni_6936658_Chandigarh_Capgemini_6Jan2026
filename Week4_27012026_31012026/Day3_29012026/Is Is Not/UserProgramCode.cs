using System;
using System.Collections.Generic;
using System.Text;

namespace Is_Is_Not
{
    internal class UserProgramCode
    {
        public static string NegativeString(string input)
        {
            int n = input.Length;
            if (input.Contains("is not"))
            {
                return input;
            }
            if (input.Contains("is")) {
                int idx = input.IndexOf(" is") + 4;
                input = input.Insert(idx, "not ");
            }
            return input;

        }
    }
}
