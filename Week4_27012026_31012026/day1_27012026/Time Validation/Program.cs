using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace levelI_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int ans = UserProgramCode.validateTime(str);

            if (ans == 1)
                Console.WriteLine("Valid time format");
            else if (ans == -1)
                Console.WriteLine("Invalid time format");
        }
    }
}
class UserProgramCode
{
    public static int validateTime(string str)
    {


        int hr, min;

        hr = int.Parse(str.Substring(0, 2));
        min = int.Parse(str.Substring(3, 2));
        string suf = str.Substring(5, 3);


        if (hr > 12 || min > 60 || suf != " am" && suf != " pm")
            return -1;
        else
            return 1;


    }
}
