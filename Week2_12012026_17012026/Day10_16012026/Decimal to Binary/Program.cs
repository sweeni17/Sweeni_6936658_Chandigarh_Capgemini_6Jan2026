namespace Decimal_to_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter DecimalNumber:");
            int Decimal = int.Parse(Console.ReadLine());

            if (Decimal < 0)
            {
                Console.WriteLine("Output = -1");
                return;
            }
            int temp = Decimal;
            int count = 0;

            while (temp > 0)
            {
                count++;
                temp = temp / 2;
            }

            int[] Binary = new int[count];
            int Index = count - 1;
            while (Decimal > 0)
            {
                int rem = Decimal % 2;
                Binary[Index] = rem;
                Decimal = Decimal / 2;
                Index--;
            }
            Console.WriteLine("Binary: ");
            for (int i = 0; i < Binary.Length; i++)
            {
                Console.Write(Binary[i] + " ");
            }
        }
    }
}
