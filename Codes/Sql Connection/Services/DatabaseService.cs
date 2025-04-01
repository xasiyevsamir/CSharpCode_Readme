using System.Data.SqlClient;

namespace Sql_Connection.Services
{
    public class DatabaseService
    {
        static DatabaseService()
        {
            string masterConnectionString = "Server=.; Database=master; User=sa; Password=Salam123@; TrustServerCertificate=True";
            string checkDatabaseQuery = $@"
                IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'AdoNet')
                BEGIN
                    CREATE DATABASE AdoNet
                END";
            using SqlConnection connection = new SqlConnection(masterConnectionString);
            connection.Open();
            using SqlCommand command = new SqlCommand(checkDatabaseQuery, connection);
            int value = command.ExecuteNonQuery();
            if (value == 1)
                Console.WriteLine("Adonet Database yaradildi");           
        }
    }
}
