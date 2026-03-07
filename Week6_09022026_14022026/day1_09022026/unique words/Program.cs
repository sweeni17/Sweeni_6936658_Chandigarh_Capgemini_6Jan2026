using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] words = { "listen", "silent", "hello", "world", "abc", "cba" };

        Dictionary<string, int> map = new Dictionary<string, int>();

        foreach (string w in words)
        {
            string key = string.Concat(w.OrderBy(c => c));
            map[key] = map.ContainsKey(key) ? map[key] + 1 : 1;
        }

        foreach (string w in words)
        {
            string key = string.Concat(w.OrderBy(c => c));
            if (map[key] == 1)
                Console.Write(w + " ");
        }
    }
}
