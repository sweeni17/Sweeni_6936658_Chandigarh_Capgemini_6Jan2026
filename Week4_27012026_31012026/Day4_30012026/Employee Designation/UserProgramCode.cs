using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_designation
{
    internal class UserProgramCode
    {
        public static string[] getEmployee(string[] input1, string input2)
        {
            int n = input1.Length;
            string[] res = new string[n];
            foreach (string s in input1)
            {
                foreach (char c in s)
                {
                    if (!char.IsLetter(c))
                    {
                        return new string[] { "Invalid Input" };
                    }
                }
            }
            int idx = 0;
            for (int i = 1; i < n; i += 2)
            {
                if (input1[i].Equals(input2, StringComparison.OrdinalIgnoreCase))
                {
                    res[idx++] = input1[i - 1];
                }
            }
            Array.Resize(ref res, idx);
            if (idx == 0)
            {
                return new string[] { "No employee for " + input2 + " designation" };
            }
            if (idx == n / 2)
            {
                return new string[] { "All employees belong to same " + input2 + " designation" };
            }

            return res;
        }
    }
}