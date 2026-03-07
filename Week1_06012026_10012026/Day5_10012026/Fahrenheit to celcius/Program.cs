namespace Fahrenheit_to_celcius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input1 = 98.6;  
            double output;
            if (input1 < 0)
            {
                output = -1;
            }
            else
            {
                output = (input1 - 32) * 5 / 9;
            }

            Console.WriteLine("Output = " + output);
        }
    }
}
