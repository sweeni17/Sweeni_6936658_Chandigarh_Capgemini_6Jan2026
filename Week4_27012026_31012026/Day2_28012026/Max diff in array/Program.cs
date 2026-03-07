namespace Max_diff_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine(UserProgramCode.diffIntArray(arr));
        }
    }
}
