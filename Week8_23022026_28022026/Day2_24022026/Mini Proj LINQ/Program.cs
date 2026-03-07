namespace Mini_Proj_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
        {
            new Student { StudentID = 1, Name = "Atharva", Age = 20, DepartmentID = 1 },
            new Student { StudentID = 2, Name = "Barkha", Age = 22, DepartmentID = 1 },
            new Student { StudentID = 3, Name = "Taranya", Age = 23, DepartmentID = 2 },
            new Student { StudentID = 4, Name = "Pragyansh", Age = 21, DepartmentID = 2 },
            new Student { StudentID = 5, Name = "Miraya", Age = 19, DepartmentID = 3 }
        };

            // Departments
            List<Department> departments = new List<Department>
        {
            new Department { DepartmentID = 1, DepartmentName = "Computer Science" },
            new Department { DepartmentID = 2, DepartmentName = "Electronics" },
            new Department { DepartmentID = 3, DepartmentName = "Mechanical" }
        };

            // Courses
            List<Course> courses = new List<Course>
        {
            new Course { CourseID = 1, CourseName = "Databases", DepartmentID = 1 },
            new Course { CourseID = 2, CourseName = "Operating Systems", DepartmentID = 1 },
            new Course { CourseID = 3, CourseName = "Digital Circuits", DepartmentID = 2 },
            new Course { CourseID = 4, CourseName = "Thermodynamics", DepartmentID = 3 }
        };

            // Enrollments
            List<Enrollment> enrollments = new List<Enrollment>
        {
            new Enrollment { EnrollmentID = 1, StudentID = 1, CourseID = 1, Grade = "A" },
            new Enrollment { EnrollmentID = 2, StudentID = 1, CourseID = 2, Grade = "B" },
            new Enrollment { EnrollmentID = 3, StudentID = 2, CourseID = 1, Grade = "A" },
            new Enrollment { EnrollmentID = 4, StudentID = 3, CourseID = 3, Grade = "C" },
            new Enrollment { EnrollmentID = 5, StudentID = 4, CourseID = 3, Grade = "B" }
        };
            static void GetStudentsOlderThan21(List<Student> students)
            {
                var result = students
                                .Where(s => s.Age > 21);

                Console.WriteLine("Students older than 21:");
                foreach (var student in result)
                {
                    Console.WriteLine(student.Name + " - Age: " + student.Age);
                }
            }

            static void GetCoursesByDepartment(List<Course> courses, int deptId)
            {
                var result = courses
                                .Where(c => c.DepartmentID == deptId);

                Console.WriteLine("Courses in Department ID " + deptId + ":");
                foreach (var course in result)
                {
                    Console.WriteLine(course.CourseName);
                }
            }

            static void GetStudentsInDatabases(
    List<Student> students,
    List<Course> courses,
    List<Enrollment> enrollments)
            {
                var result = students
                    .Join(enrollments,
                          s => s.StudentID,
                          e => e.StudentID,
                          (s, e) => new { s, e })
                    .Join(courses,
                          se => se.e.CourseID,
                          c => c.CourseID,
                          (se, c) => new { se.s.Name, c.CourseName })
                    .Where(x => x.CourseName == "Databases");

                Console.WriteLine("Students enrolled in Databases:");
                foreach (var item in result)
                {
                    Console.WriteLine(item.Name);
                }
            }

            GetStudentsOlderThan21(students);
            Console.WriteLine();

            GetCoursesByDepartment(courses, 1);
            Console.WriteLine();

            GetStudentsInDatabases(students, courses, enrollments);
            Console.WriteLine();
        }
    }
}
