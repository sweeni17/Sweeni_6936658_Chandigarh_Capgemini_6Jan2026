namespace Bank_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount account = new SavingsAccount();
            account.depositAmt(3200);
            Console.WriteLine();
            account.withdrawAmt(650);
            Console.WriteLine();
            account.DisplaySummary();
            Console.WriteLine();
            account.Interest();

        }
    }
}
