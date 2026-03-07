using System;

class Program
{
    static void Main()
    {
        string s = "I love programming.";
        char oldChar = '.';
        char newChar = '!';

        int index = s.IndexOf(oldChar);
        if (index != -1)
            s = s.Remove(index, 1).Insert(index, newChar.ToString());

        Console.WriteLine(s);
    }
}
