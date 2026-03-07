namespace Vehicle_Rental_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = null;
            Customer c = null;
            RentalTransaction rt = null;

            int choice;
            do
            {
                Console.WriteLine("\n---- Vehicle Rental System ----");
                Console.WriteLine("1. Add Car");
                Console.WriteLine("2. Add Bike");
                Console.WriteLine("3. Add Truck");
                Console.WriteLine("4. Rent Vehicle");
                Console.WriteLine("5. Return Vehicle");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: v = new Car(); break;
                    case 2: v = new Bike(); break;
                    case 3: v = new Truck(); break;

                    case 4:
                        if (v != null && v.IsAvailable)
                        {
                            c = new Customer();
                            rt = new RentalTransaction(v, c);
                            rt.DisplayBill();
                        }
                        else
                            Console.WriteLine("Vehicle not available!");
                        break;

                    case 5:
                        if (rt != null)
                            rt.ReturnVehicle();
                        else
                            Console.WriteLine("No active rental!");
                        break;
                }

            } while (choice != 6);
        }
    }
}
