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

                // Example for Sql Data Reader
                string query = "SELECT TOP(10) * FROM Employees ORDER BY Salary DESC;";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Console.WriteLine($"{sqlDataReader[0]} - {sqlDataReader["FirstName"]} - {sqlDataReader["Salary"]}");
                }
            }

        }
    }
}
