using System.Data.SqlClient;

namespace Sql_Connection.Services
{
    public class CreateTableService
    {
        public void StudentsCreateTable(string connectionString)
        {
            string query = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Students')
                BEGIN
                    CREATE TABLE Students
                    (
                        Id INT PRIMARY KEY IDENTITY,
                        Name NVARCHAR(100),
                        Surname NVARCHAR(100)
                    );
                END";
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public void StudentDetailsCreateTable(string connectionString)
        {
            string query = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'StudentDetails')
                BEGIN
                    CREATE TABLE StudentDetails
                    (
                        Id INT PRIMARY KEY IDENTITY,
                        Address NVARCHAR(200) NOT NULL,
                        Email  VARCHAR(200) NOT NULL,
                        StudentId INT UNIQUE, 
                        FOREIGN KEY (StudentId) REFERENCES Students(Id)
                    );
                END";
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }
}
