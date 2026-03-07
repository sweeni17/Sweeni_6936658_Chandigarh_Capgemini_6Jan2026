using Microsoft.Data.SqlClient;
using System.Data;
using System;

namespace Library_management_system
{
    internal class Program
    {
        static string connectionString =
"Server=DESKTOP-1IH1IR8\\SQLEXPRESS;" +
"Database=LibraryDB;" +
"Integrated Security=True;" +
"TrustServerCertificate=True;";

        static void Main(string[] args)
        {

            try
            {
                GetRecordWithMemberBooksAuthor();
                InsertBookWithValidation("AI Basics", 1, 2024);
                UpdateReturnDate(1, DateTime.Now);
                DeleteBorrowRecord(3);


            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            Console.ReadLine();
        }
        static void GetRecordWithMemberBooksAuthor()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetRecordWithMemberBooksAuthor", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["RecordId"]} | {reader["BorrowDate"]} | {reader["ReturnDate"]} | {reader["MemberName"]} | {reader["Title"]}");
                }
            }
        }
        static void InsertBookWithValidation(string title, int authorId, int year)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("InsertBookWithValidation", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@AuthorId", authorId);
                cmd.Parameters.AddWithValue("@PublishedYear", year);

                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Book inserted");
            }
        }
        static void UpdateReturnDate(int recordId, DateTime returnDate)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateReturnDate", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RecordId", recordId);
                cmd.Parameters.AddWithValue("@ReturnDate", returnDate);

                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Return date updated");
            }
        }

        static void DeleteBorrowRecord(int recordId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DeleteBorrowRecord", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RecordId", recordId);

                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Borrow record deleted");
            }
        }

    }
}