using System;
using System.Collections.Generic;
using System.Text;

namespace Digit_sum_in_string_array
{
    internal class UserProgramCode
    {
        public static int sumOfDigits(string[] input1)
        {
            int sum = 0;
            foreach(string s in input1)
            {
                foreach(char c in s)
                {
                    if (Char.IsDigit(c))
                    {
                        sum += c - '0';
                    }
                    else if (Char.IsLetter(c))
                    {
                        continue;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            return sum;
        }
    }
}
