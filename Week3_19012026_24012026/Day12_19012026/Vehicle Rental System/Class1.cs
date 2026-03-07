using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_System
{
    internal class Vehicle
    {
        public int VehicleId;
        public string Brand;
        public double RatePerDay;
        public bool IsAvailable = true;

        public Vehicle()
        {
            Console.Write("Enter Vehicle ID: ");
            VehicleId = int.Parse(Console.ReadLine());
            Console.Write("Enter Brand: ");
            Brand = Console.ReadLine();
            Console.Write("Enter Rate per Day: ");
            RatePerDay = double.Parse(Console.ReadLine());
        }

        public virtual double CalculateRent(int days)
        {
            return RatePerDay * days;
        }

        public void DisplayVehicle()
        {
            Console.WriteLine("\nVehicle ID : " + VehicleId);
            Console.WriteLine("Brand      : " + Brand);
            Console.WriteLine("Rate/Day   : " + RatePerDay);
            Console.WriteLine("Available  : " + IsAvailable);
        }
    }

    class Car : Vehicle
    {
        public int Seats;

        public Car()
        {
            Console.Write("Enter Number of Seats: ");
            Seats = int.Parse(Console.ReadLine());
        }

        public override double CalculateRent(int days)
        {
            return base.CalculateRent(days) + 500; 
        }
    }

    class Bike : Vehicle
    {
        public bool IsGear;

        public Bike()
        {
            Console.Write("Is Gear Bike (true/false): ");
            IsGear = bool.Parse(Console.ReadLine());
        }

        public override double CalculateRent(int days)
        {
            return base.CalculateRent(days);
        }
    }

    class Truck : Vehicle
    {
        public int LoadCapacity;

        public Truck()
        {
            Console.Write("Enter Load Capacity (tons): ");
            LoadCapacity = int.Parse(Console.ReadLine());
        }

        public override double CalculateRent(int days)
        {
            return base.CalculateRent(days) + 1000;
        }
    }

    class Customer
    {
        public int CustomerId;
        public string Name;

        public Customer()
        {
            Console.Write("Enter Customer ID: ");
            CustomerId = int.Parse(Console.ReadLine());
            Console.Write("Enter Customer Name: ");
            Name = Console.ReadLine();
        }

        public void DisplayCustomer()
        {
            Console.WriteLine("Customer ID : " + CustomerId);
            Console.WriteLine("Name        : " + Name);
        }
    }

    class RentalTransaction
    {
        public Vehicle vehicle;
        public Customer customer;
        public int days;
        public double totalAmount;

        public RentalTransaction(Vehicle v, Customer c)
        {
            vehicle = v;
            customer = c;

            Console.Write("Enter number of rental days: ");
            days = int.Parse(Console.ReadLine());

            totalAmount = vehicle.CalculateRent(days);
            vehicle.IsAvailable = false;
        }

        public void DisplayBill()
        {
            Console.WriteLine("\n----- Rental Bill -----");
            customer.DisplayCustomer();
            vehicle.DisplayVehicle();
            Console.WriteLine("Days Rented : " + days);
            Console.WriteLine("Total Rent  : ₹" + totalAmount);
        }

        public void ReturnVehicle()
        {
            vehicle.IsAvailable = true;
            Console.WriteLine("Vehicle Returned Successfully!");
        }
    }

}
