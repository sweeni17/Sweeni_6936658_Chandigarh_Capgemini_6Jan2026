namespace Correct_Answer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the capital of India?");
            Console.WriteLine("A. Mumbai");
            Console.WriteLine("B. Delhi");
            Console.WriteLine("C. Chandigarh");
            Console.WriteLine("D. Banglore");
            Console.Write("Choose the correct answer: ");
            char Answer = char.Parse(Console.ReadLine());

            if (Answer == 'B' || Answer == 'b')
            {
                Console.WriteLine("Correct Answer");
            }
            else
            {
                Console.WriteLine("Incorrect Answer");
            }
        }
    }
}
