using Donation;

namespace Donations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter input size: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter input1: ");
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("enter input2: ");
            int Input2 = int.Parse(Console.ReadLine());
            Console.WriteLine(UserProgramCode.getDonation(arr, Input2));

        }
    }
}
