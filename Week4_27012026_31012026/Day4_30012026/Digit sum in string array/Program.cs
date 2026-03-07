namespace Digit_sum_in_string_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            Console.WriteLine("Enter elements:");
            for(int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine(UserProgramCode.sumOfDigits(arr));
        }
    }
}
