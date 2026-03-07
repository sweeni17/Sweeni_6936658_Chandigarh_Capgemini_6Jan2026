namespace Class_employee
{
    public class Employee
    {
        public int EmpId;
        public string Name;
        public int Age;
        public string Department;

        public void GetData()
        {
            Console.Write("Enter Employee Details: ");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.Name = Console.ReadLine();
            this.Age = Convert.ToInt32(Console.ReadLine());
            this.Department = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("Employee ID is " + this.EmpId);
            Console.WriteLine("Employee Name is " + this.Name);
            Console.WriteLine("Employee Age is " + this.Age);
            Console.WriteLine("Employee Department is " + this.Department);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.GetData();
            emp1.DisplayData();
        }
    }
}
