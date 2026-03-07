namespace KeyPressed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key");
            string key = (Console.ReadLine());
            switch (key)
            {
                case "0":
                    Console.WriteLine("Key Pressed: 0");
                    break;

                case "1":
                    Console.WriteLine("Key Pressed: 1");
                    break;

                case "2":
                    Console.WriteLine("Key Pressed: 2");
                    break;

                case "3":
                    Console.WriteLine("Key Pressed: 3");
                    break;

                case "4":
                    Console.WriteLine("Key Pressed: 4");
                    break;

                case "5":
                    Console.WriteLine("Key Pressed: 5");
                    break;

                case "6":
                    Console.WriteLine("Key Pressed: 6");
                    break;

                case "7":
                    Console.WriteLine("Key Pressed: 7");
                    break;

                case "8":
                    Console.WriteLine("Key Pressed: 8");
                    break;

                case "9":
                    Console.WriteLine("Key Pressed: 9");
                    break;

                default:
                    Console.WriteLine("Not allowed");
                    break;
            }
        }
    }
}
