using System;
using System.Collections.Generic;
using System.Text;

namespace Roman_to_Decimal
{
    internal class UserProgramCode
    {
        public static int ConvertRomanToDecimal(string input)
        {
            int sum = 0;
            foreach (char c in input)
            {

                switch (c)
                {
                    case 'I': sum += 1;
                        break;

                    case 'V': sum += 5;
                        break;

                    case 'X': sum += 10;
                        break;

                    case 'L': sum += 50;
                        break;

                    case 'C': sum += 100;
                        break;

                    case 'D': sum += 500;
                        break;

                    case 'M': sum += 1000;
                        break;

                    default: return -1;
                }
            }
            return sum;
        }
    }
}
