using System;
using System.Data.SqlClient;

namespace DbDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var connection = new SqlConnection("Server=UNO-PC\\SQLEXPRESS;Integrated Security=true;Database=SoftUni;"))
            {
                connection.Open();

                // Example for Select
                string query = "SELECT * FROM Employees;";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                Console.WriteLine(sqlCommand.ExecuteScalar());

                // Example for Update
                var updateCommand = new SqlCommand("UPDATE Employees SET Salary = Salary + 10", connection);
                var rowsAffected = updateCommand.ExecuteNonQuery();
                Console.WriteLine(rowsAffected);
            }

        }
    }
}
