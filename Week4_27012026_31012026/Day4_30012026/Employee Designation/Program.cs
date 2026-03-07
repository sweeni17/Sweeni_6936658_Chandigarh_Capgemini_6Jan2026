namespace Employee_designation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size:");
            int n = int.Parse(Console.ReadLine());
            string[] str = new string[n];

            Console.WriteLine("enter Employee & designation: ");
            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter employees designation: ");
            string input2 = Console.ReadLine();

            string[] result = UserProgramCode.getEmployee(str, input2);

            foreach (string str2 in result)
            {
                Console.WriteLine("Employee name for " + input2 + " : " + str2);
            }
        }
    }
}