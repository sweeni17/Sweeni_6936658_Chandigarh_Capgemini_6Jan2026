using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System
{
    internal class Person
    {
        public int Id;
        public string Name;
        public int Age;

        public Person()
        {
            Console.Write("Enter ID: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Age: ");
            Age = int.Parse(Console.ReadLine());
        }

        public void DisplayProfile()
        {
            Console.WriteLine("\nID   : " + Id);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age  : " + Age);
        }
    }

    class Patient : Person
    {
        public MedicalRecord record;

        public Patient()
        {
            record = new MedicalRecord();
        }

        public void ViewMedicalHistory()
        {
            record.DisplayRecord();
        }
    }

    class Doctor : Person
    {
        public string Specialization;

        public Doctor()
        {
            Console.Write("Enter Specialization: ");
            Specialization = Console.ReadLine();
        }

        public void DisplayDoctor()
        {
            Console.WriteLine("Specialization : " + Specialization);
        }
    }

    class Nurse : Person
    {
        public string Shift;

        public Nurse()
        {
            Console.Write("Enter Shift (Day/Night): ");
            Shift = Console.ReadLine();
        }

        public void DisplayNurse()
        {
            Console.WriteLine("Shift : " + Shift);
        }
    }

    class MedicalRecord
    {
        private string diagnosis;
        private string treatment;

        public MedicalRecord()
        {
            Console.Write("Enter Diagnosis: ");
            diagnosis = Console.ReadLine();
            Console.Write("Enter Treatment: ");
            treatment = Console.ReadLine();
        }

        public void DisplayRecord()
        {
            Console.WriteLine("Diagnosis : " + diagnosis);
            Console.WriteLine("Treatment : " + treatment);
        }
    }

    class Appointment
    {
        public Patient patient;
        public Doctor doctor;
        public string Date;

        public Appointment(Patient p, Doctor d)
        {
            patient = p;
            doctor = d;
            Console.Write("Enter Appointment Date: ");
            Date = Console.ReadLine();
        }

        public void DisplayAppointment()
        {
            Console.WriteLine("\n---- Appointment Details ----");
            Console.WriteLine("Patient : " + patient.Name);
            Console.WriteLine("Doctor  : " + doctor.Name);
            Console.WriteLine("Date    : " + Date);
        }
    }


}
