using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter number of friends (N):");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of seconds (T):");
        int T = int.Parse(Console.ReadLine());

        if (N <= 0 || T <= 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        // Who receives the ball at second T
        int receiver = (T % N == 0) ? N : T % N;

        // Who passed it in the last second
        int passer = (receiver == 1) ? N : receiver - 1;

        Console.WriteLine("In the last second:");
        Console.WriteLine("Friend " + passer + " passed the ball to Friend " + receiver);
    }
}
