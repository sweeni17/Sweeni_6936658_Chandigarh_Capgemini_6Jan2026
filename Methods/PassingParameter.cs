using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    internal class PassingParameter
    {
        void test1()
        {
            Console.WriteLine("first");
        }

        void test2(int x)
        {
            Console.WriteLine("This is second method");
        }

        string test3()
        {
            return "This is third method";
        }

        string test4(string name)
        {
            return "fourth" + name;
        }

        void math1(int x, int y, ref int a,  ref int b)
        {
            a = x + y;
            b = x * y;
        }

        void math2(int x, int y, out int a, out int b)
        {
            a = x - y;
            b = x / y;
        }

        public static void Main(string[] args)
        {
            PassingParameter p = new PassingParameter();
            p.test1();
            p.test2(200);
            Console.WriteLine(p.test3());
            Console.WriteLine(p.test4("sweeni"));
            int m = 0, n = 0;
            p.math1(100, 50, ref m, ref n);
            Console.WriteLine(m+" "+n);
            int q, r;
            p.math2(100, 50, out  q, ref r);
            Console.WriteLine(q+" "+r);
            Console.ReadLine();
        }
    }
}
