namespace Insert_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter array size:");
                int Input2 = int.Parse(Console.ReadLine());

                if (Input2 < 0)
                {
                    Console.WriteLine("Output: -2");
                    return;
                }

                int[] Input1 = new int[Input2];

                Console.WriteLine("Enter array elements:");
                for (int i = 0; i < Input2; i++)
                {
                    Input1[i] = int.Parse(Console.ReadLine());

                    if (Input1[i] < 0)
                    {
                        Console.WriteLine("Output: -1");
                        return;
                    }
                }

                Array.Sort(Input1);

                Console.WriteLine("Enter element to insert:");
                int Input3 = int.Parse(Console.ReadLine());

                int[] Output = new int[Input2 + 1];
                int index = 0;
                bool Inserted = false;

                for (int i = 0; i < Input2; i++)
                {
                    if (!Inserted && Input3 < Input1[i])
                    {
                        Output[index++] = Input3;
                        Inserted = true;
                    }

                    Output[index++] = Input1[i];
                }

                if (!Inserted)
                {
                    Output[index] = Input3;
                }

                Console.WriteLine("Output:");
                for (int i = 0; i < Input2 + 1; i++)
                {
                    Console.Write(Output[i] + " ");
                }
            }
        }
    }

