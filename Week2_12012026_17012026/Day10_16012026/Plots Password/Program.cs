namespace Plots_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of plots: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Output: -2");
                return;
            }
            int[] Plotnum = new int[num];
            int oddsum = 0;
            int evensum = 0;
            Console.WriteLine("Enter plot numbers: ");
            for (int i = 0; i < num; i++)
            {
                Plotnum[i] = int.Parse(Console.ReadLine());
                if ( Plotnum[i] < 0)
                {
                    Console.WriteLine("Output: -1");
                    return;
                }

            }

            for (int i= 0; i<num; i++)
            {

                if (Plotnum[i] % 2 == 0)
                {
                    evensum += Plotnum[i];
                    
                }
                else
                {
                    oddsum += Plotnum[i];
                    
                }
            }

            int Password = (evensum + oddsum) / 2;
            Console.WriteLine("Password: " + Password);

        }
    }
}
