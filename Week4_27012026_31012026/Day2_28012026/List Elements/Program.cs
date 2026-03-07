using List_element;

namespace List_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements: ");
            List<int> l = new List<int>();
            for (int i = 0; i < n; i++)
            {
                l.Add(int.Parse(Console.ReadLine()));
                
            }
            int Input2 = int.Parse(Console.ReadLine());
            List<int> res = UserProgramCode.GetElement(l, Input2);
            Console.Write("Result: ");
            foreach(int x in res)
            {
                Console.WriteLine(x + " "); 
            }
        }
    }
}
