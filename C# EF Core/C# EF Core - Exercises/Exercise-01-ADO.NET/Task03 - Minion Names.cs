using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DbDemo
{
    public class Program
    {
        const string SqlConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MinionsDB;Integrated Security=true";

        public static void Main(string[] args)
        {
            using (var connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                // Select Villain by Id
                int villainId = int.Parse(Console.ReadLine());

                string villainNameQuery = "SELECT Name FROM Villains WHERE Id = @Id";
                var command = new SqlCommand(villainNameQuery, connection);
                command.Parameters.AddWithValue("@Id", villainId);
                string villainName = command.ExecuteScalar() as string;

                if (villainName == null)
                {
                    Console.WriteLine($"No villain with ID {villainId} exists in the database.");
                }
                else
                {
                    var commandReader = new SqlCommand(@"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) as RowNum, m.Name, m.Age FROM MinionsVillains AS mv 
                            JOIN Minions As m ON mv.MinionId = m.Id WHERE mv.VillainId = @Id ORDER BY m.Name", connection);
                    commandReader.Parameters.AddWithValue("@Id", villainId);
                    var reader = commandReader.ExecuteReader();

                    Console.WriteLine($"Villain: {villainName}");

                    if (reader.HasRows == false)
                    {
                        Console.WriteLine("(no minions)");
                        return;
                    }

                    while (reader.Read())
                    {
                        var rowNumber = reader[0];
                        var minionName = reader[1];
                        var age = reader[2];
                        Console.WriteLine($"{rowNumber}. {minionName} {age}");
                    }
                }

            }
        }

    }
}
