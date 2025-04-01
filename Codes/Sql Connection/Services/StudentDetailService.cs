using System.Data.SqlClient;

namespace Sql_Connection.Services
{
    public class StudentDetailService
    {

        public void CreateTable(string connectionString)
        {
            string query = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'StudentDetail')
                BEGIN
                    CREATE TABLE StudentDetails
                    (
                        Id INT PRIMARY KEY IDENTITY,
                        Address NVARCHAR(200),
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
