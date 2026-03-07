namespace Count_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size: ");
            int size = int.Parse(Console.ReadLine());
            string[] arr = new string[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter character: ");
            char ch = char.Parse(Console.ReadLine());
            int result = UserProgramCode.GetCount(size, arr, ch);
            if (result == -1)
            {
                Console.WriteLine("No elements found");
            }
            else if (result == -2)
            {

                Console.WriteLine("Only alphabets should be given");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
