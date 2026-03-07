namespace Sum_Largest_num_in_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input size: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input : ");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int output = LargestNumber.UserProgramCode.largestNumber(arr);

            Console.WriteLine("Sum of largest in range: " + output);
        }
    }
}
