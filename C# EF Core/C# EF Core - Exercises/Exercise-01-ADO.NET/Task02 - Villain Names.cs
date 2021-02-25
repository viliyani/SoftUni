using System;
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

                var sqlQuery = @"SELECT Name, MinionsNumber
                                    FROM Villains v
                                    JOIN (SELECT VillainId, COUNT(MinionId) AS MinionsNumber                    FROM MinionsVillains GROUP BY VillainId) AS vm
                                        ON v.Id = vm.VillainId
                                    WHERE MinionsNumber > 2
                                    ORDER BY MinionsNumber DESC;";


                var command = new SqlCommand(sqlQuery, connection);
                var sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Console.WriteLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
                }
            }
        }

    }
}
