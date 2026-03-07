namespace Form_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            string[] arr = new string[k];

            for (int i = 0; i < k; i++)
            {
                arr[i] = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());

            string output = UserProgramCode.formString(arr, n);
            Console.WriteLine(output);
        }
    }
}