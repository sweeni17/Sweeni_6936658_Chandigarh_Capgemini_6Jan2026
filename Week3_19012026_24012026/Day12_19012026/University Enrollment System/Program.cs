namespace University_Enrollment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n------ University Enrollment System ------");
                Console.WriteLine("1. Register Student");
                Console.WriteLine("2. Register Professor");
                Console.WriteLine("3. Register Staff");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Student s = new Student();
                        s.DisplayProfile();
                        s.DisplayStu();
                        break;

                    case 2:
                        Professor p = new Professor();
                        p.DisplayProfile();
                        p.DisplayProf();
                        break;

                    case 3:
                        Staff st = new Staff();
                        st.DisplayProfile();
                        st.DisplayStaff();
                        break;

                    case 4:
                        Console.WriteLine("Exiting system...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (choice != 4);
        }
    }
}
