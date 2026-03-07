namespace Student_s_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marks");
            int marks = int.Parse(Console.ReadLine());
            if (marks >= 90 && marks <=100)
            {
                Console.WriteLine("A+ Grade. You are Excellent!");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("A Grade. You are doing good.");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("B Grade. You can do better.");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("C Grade. You definitely need practice.");
            }
            else
            {
                Console.WriteLine("F!!! Padhle Bhai... Aise ghr nhi chlta");
            }
        }
    }
}
