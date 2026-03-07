using System;
using System.Collections.Generic;
using System.Text;

namespace University_Enrollment_System
{
    internal class Person
    {
        public int Id;
        public string Name;
        public string gender;
        public int phoneNo;

        public Person()
        {
            Console.WriteLine("Enter ID: ");
            this.Id = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter Name: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Gender: ");
            this.gender = Console.ReadLine();
            Console.WriteLine("Enter Phone Number: ");
            this.phoneNo = int.Parse(Console.ReadLine());
        }

        public void DisplayProfile()
        {
            Console.Write(" ");
            Console.WriteLine("------------Profile-----------");
            Console.WriteLine("ID         :     " + Id);
            Console.WriteLine("Name       :     " + Name);
            Console.WriteLine("Gender     :     " + gender);
            Console.WriteLine("Phone no   :     "+ phoneNo);
        }
    }

    class Student : Person
    {
        public string dept;
        public Student()
        {
            Console.WriteLine("Enter Department: ");
            this.dept = Console.ReadLine();
        }

        public void DisplayStu()
        {
            Console.WriteLine("Student's Department  :  " + dept);
        }
    }

    class Professor : Person
    {
        public string course;
        public Professor()
        {
            Console.WriteLine("Assign course to the professor : ");
            this.course = Console.ReadLine();
        }

        public void DisplayProf()
        {
            Console.WriteLine("Professor's course  :  " + course);
        }
    }

    class Staff : Person
    {
        public string task;
        public Staff()
        {
            Console.WriteLine("Assign a task: ");
            this.task = Console.ReadLine();
        }

        public void DisplayStaff()
        {
            Console.WriteLine("Staff's Task  :  " + task);
        }
    }

    class Course
    {
        public string CourseName;
        public int Credits;

        public Course()
        {
            Console.WriteLine("Enter Course Name: ");
            CourseName = Console.ReadLine();
            Console.WriteLine("Enter Credits: ");
            Credits = int.Parse(Console.ReadLine());
        }

        public void DisplayCourse()
        {
            Console.WriteLine("Course Name : " + CourseName);
            Console.WriteLine("Credits     : " + Credits);
        }
    }

    class Department
    {
        public string DeptName;

        public Department()
        {
            Console.WriteLine("Enter Department Name: ");
            DeptName = Console.ReadLine();
        }

        public void DisplayDepartment()
        {
            Console.WriteLine("Department : " + DeptName);
        }
    }

}
