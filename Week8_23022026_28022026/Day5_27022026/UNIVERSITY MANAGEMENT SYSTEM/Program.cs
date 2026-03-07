using System.Data;
using Microsoft.Data.SqlClient;

namespace UNIVERSITY_MANAGEMENT_SYSTEM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString =
"Server=DESKTOP-1IH1IR8\\SQLEXPRESS;" +
"Database=UniversityDB;" +
"Integrated Security=True;" +
"TrustServerCertificate=True;";

                GetAllStudents(connectionString);

                InsertIntoStudentWithDeptID(connectionString,
                    "Sweeni",
                    "Choudhary",
                    "sweenichoudhary@gmail.com",
                    "Computer Science"
                    );

                UpdateStudentWithDept(connectionString,
                    2431,
                    "Diksha",
                    "Sharma",
                    "dikshasharma2004@gmail.com",
                    "Computer Science",
                    04
                    );

                DeleteFromStudentWithDeptID(connectionString,
                    2431
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            Console.ReadLine();
        }

        static void GetAllStudents(string connectionString)
        {
            Console.WriteLine("GetAllStudents Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("GetAllStudents", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"StudentID: {reader["StudentID"]}, " +
                        $"FirstName: {reader["FirstName"]}, " +
                        $"LastName: {reader["LastName"]}, " +
                        $"Email: {reader["Email"]}," +
                        $"DeptName: {reader["DeptName"]}"
                    );
                }

                reader.Close();
                connection.Close();
            }
        }

        // ================= CREATE STUDENT =================
        static void InsertIntoStudentWithDeptID(
            string connectionString,
            string FirstName,
            string LastName,
            string Email,
            string DeptName)
        {
            Console.WriteLine("InsertIntoStudentWithDeptID Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("InsertIntoStudentWithDeptID", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@DeptName", DeptName);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                Console.WriteLine("Student created successfully.\n");
            }
        }

        // ================= UPDATE STUDENT =================
        static void UpdateStudentWithDept(
            string connectionString,
            int StudentID,
            string FirstName,
            string LastName,
            string Email,
            string DeptName,
            int DeptID)
        {
            Console.WriteLine("UpdateStudentWithDept Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("UpdateStudentWithDept", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StudentID", StudentID);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@DeptName", DeptName);
                command.Parameters.AddWithValue("@DeptID", DeptID);


                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                Console.WriteLine("Student updated successfully.\n");
            }
        }

        // ================= DELETE STUDENT =================
        static void DeleteFromStudentWithDeptID(string connectionString, int StudentID)
        {
            Console.WriteLine("DeleteFromStudentWithDeptID Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("DeleteFromStudentWithDeptID", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StudentID", StudentID);

                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result > 0)
                    Console.WriteLine("Student deleted successfully.\n");
                else
                    Console.WriteLine("Student not found.\n");

                connection.Close();
            }
        }
    }
}
