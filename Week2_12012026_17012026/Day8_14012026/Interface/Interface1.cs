using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal interface Interface1
    {
        void f1();
    }
    interface Inter2
    {
        void f1();
    }
    class C3: Interface1, Inter2
    {
        void Interface1.f1()
        {
            Console.WriteLine("this is overriding function of interface1 and inter2 interfaces.");
        }
        void Inter2.f1()
        {
            Console.WriteLine("this is overriding function of interface1 and inter2 interfaces.");
        }
    }
}
