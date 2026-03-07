using System;
using System.Collections.Generic;
using System.Text;


namespace List_element
{
    internal class UserProgramCode
    {
        public static List<int> GetElement(List<int> arr, int input)
        {
            List<int> l = new List<int>();
            int n = arr.Count;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < input)
                {
                    l.Add(arr[i]);
                }
            }
            if (l.Count == 0)
            {
                return new List<int> { -1 };
            }
            l.Sort();
            l.Reverse();
            return l;
        }
    }
}