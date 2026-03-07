using System;
using System.Collections.Generic;
using System.Text;

namespace Max_diff_in_array
{
    internal class UserProgramCode
    {
        public static int diffIntArray(int[] input1)
        {
            int n = input1.Length;

            //checking one or more than 10 elements
            if (n < 0 || n > 10)
            {
                return -2;
            }

            //checking negative elements
            for (int i = 0; i < n; i++)
            {
                if (input1[i] < 0)
                {
                    return -1;
                }
            }

            //finding max. diff in array
            int maxdiff = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    //checking duplicate elements in array
                    if (input1[i] == input1[j])
                    {
                        return -3;
                    }

                    if (input1[j] > input1[i])
                    {
                        int diff = input1[j] - input1[i];
                        if (diff > maxdiff)
                        {
                            maxdiff = diff;
                        }
                    }
                }
            }
            return maxdiff;
        }
    }
}