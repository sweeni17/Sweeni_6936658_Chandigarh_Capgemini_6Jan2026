namespace Hospital_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient = null;
            Doctor doctor = null;
            Appointment appointment = null;

            int choice;
            do
            {
                Console.WriteLine("\n---- Hospital Management System ----");
                Console.WriteLine("1. Register Patient");
                Console.WriteLine("2. Register Doctor");
                Console.WriteLine("3. Schedule Appointment");
                Console.WriteLine("4. View Medical History");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        patient = new Patient();
                        patient.DisplayProfile();
                        break;

                    case 2:
                        doctor = new Doctor();
                        doctor.DisplayProfile();
                        doctor.DisplayDoctor();
                        break;

                    case 3:
                        if (patient != null && doctor != null)
                        {
                            appointment = new Appointment(patient, doctor);
                            appointment.DisplayAppointment();
                        }
                        else
                            Console.WriteLine("Register patient and doctor first!");
                        break;

                    case 4:
                        if (patient != null)
                            patient.ViewMedicalHistory();
                        else
                            Console.WriteLine("No patient registered!");
                        break;
                }

            } while (choice != 5);
        }
    }
}
