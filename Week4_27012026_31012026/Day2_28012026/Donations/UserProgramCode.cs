using System;
using System.Collections.Generic;
using System.Text;

namespace Donation
{
    internal class UserProgramCode
    {
        public static int getDonation(String[] input1, int input2)
        {
            int n = input1.Length;

            //checking special character
            for (int i = 0; i < n; i++)
            {
                foreach (char c in input1[i])
                {
                    if (!char.IsDigit(c))
                    {
                        return -2;
                    }
                }
            }

            //checking Duplicate digits
            for (int i = 0; i < n; i++)
            {
                int usercode1 = int.Parse(input1[i].Substring(0, 3));
                for (int j = i + 1; j < n; j++)
                {
                    int usercode2 = int.Parse(input1[j].Substring(0, 3));
                    if (usercode1 == usercode2)
                    {
                        return -1;
                    }
                }
            }
            //calculate sum of donation
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int location = int.Parse(input1[i].Substring(3, 3));
                int donation = int.Parse(input1[i].Substring(6, 3));

                if (input2 == location)
                {
                    sum += donation;
                }
            }
            return sum;
        }
    }
}