namespace Sort_half_asc_half_desc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size: ");
            int size = int.Parse(Console.ReadLine());
            if (size < 0)
            {
                Console.WriteLine("-1");
            }
            Console.WriteLine("Enter array: ");
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            int mid = size / 2;
            Array.Reverse(arr, mid, size - mid);
            Console.WriteLine("Output: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
