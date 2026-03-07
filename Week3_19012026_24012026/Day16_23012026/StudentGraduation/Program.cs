using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, int> grades = new Dictionary<int, int>
        {
            {101, 78},
            {102, 45},
            {103, 37},
            {104, 94}
        };

        Func<Dictionary<int, int>, double> calculateAverage =
            g => g.Values.Average();

        Console.WriteLine("Average Grade: " + calculateAverage(grades));

        int threshold = 50;
        Predicate<int> isAtRisk = grade => grade < threshold;

        Console.WriteLine("\nStudents at Risk: ");
        foreach (var student in grades)
        {
            if (isAtRisk(student.Value))
                Console.WriteLine("Roll No: " + student.Key + ", Grade: " + student.Value);
        }

        Console.WriteLine("\nUpdating grade for Roll No 102...");
        grades[102] = 65;

        Console.WriteLine("\nStudents at Risk after update:");
        foreach (var student in grades)
        {
            if (isAtRisk(student.Value))
                Console.WriteLine("Roll No: " + student.Key + ", Grade: " + student.Value);
        }
    }
}