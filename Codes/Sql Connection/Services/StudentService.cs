using Sql_Connection.Models;
using System.Data;
using System.Data.SqlClient;

namespace Sql_Connection.Services
{
    public class StudentService
    {


        public void CreateStudentAndDetail(Student student, StudentDetail studentDetail, string connectionString)
        {
            string query = @"
                BEGIN TRANSACTION;               
                INSERT INTO Students (Name, Surname)
                VALUES (@Name, @Surname);
                DECLARE @StudentId INT = SCOPE_IDENTITY();
                INSERT INTO StudentDetails (Address, Email, StudentId)
                VALUES (@Address, @Email, @StudentId);
                COMMIT TRANSACTION;
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                {
                    sqlcommand.Parameters.AddWithValue("@Name", student.Name);
                    sqlcommand.Parameters.AddWithValue("@Surname", student.Surname);
                    sqlcommand.Parameters.AddWithValue("@Address", studentDetail.Address);
                    sqlcommand.Parameters.AddWithValue("@Email", studentDetail.Email);
                    sqlcommand.ExecuteNonQuery();
                    Console.WriteLine("Student and student detail added successfully.");
                }
            }
        }
        public List<StudentDto> GetAllStudent(string connectionString)
        {
            string query = @"
                SELECT s.*,sd.[Address],sd.Email FROM Students s
                JOIN StudentDetails sd 
                ON s.Id=sd.StudentId
            ";
            List<StudentDto> StudentDto = new List<StudentDto>();
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using SqlCommand sqlcommand = new SqlCommand(query, connection);
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    int Id = (int)sqlDataReader.GetValue(0);
                    string name = (string)sqlDataReader.GetValue(1);
                    string surname = (string)sqlDataReader.GetValue(2);
                    string address = (string)sqlDataReader.GetValue(3);
                    string email = (string)sqlDataReader.GetValue(4);
                    StudentDto.Add(new StudentDto { Id = Id, Name = name, Surname = surname, Address = address, Email = email });
                }
            }
            else
                Console.WriteLine("Baza bosdur..");

            return StudentDto;
        }

        public StudentDto GetByIdStudent(int id, string connectionString)
        {
            string query = @"
                SELECT s.*,sd.[Address],sd.Email FROM Students s
                JOIN StudentDetails sd 
                ON s.Id=sd.StudentId
                WHERE s.Id=@id
            ";
            StudentDto studentDto=default;
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using SqlCommand sqlcommand = new SqlCommand(query, connection);
            sqlcommand.Parameters.AddWithValue("id", id);
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    int Id = (int)sqlDataReader.GetValue(0);
                    string name = (string)sqlDataReader.GetValue(1);
                    string surname = (string)sqlDataReader.GetValue(2);
                    string address = (string)sqlDataReader.GetValue(3);
                    string email = (string)sqlDataReader.GetValue(4);
                    studentDto = new StudentDto() { Id = Id, Name = name, Surname = surname, Address = address, Email = email };

                }
            }

            else
                Console.WriteLine($"Id-si {id} olan Student bazada yodur");

            return studentDto;
        }

        public void Delete(int id, string connectionString)
        {
            string query = @"DELETE FROM Students WHERE Id = @id";
            StudentDto studentDto = default;
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using SqlCommand sqlcommand = new SqlCommand(query, connection);
            sqlcommand.Parameters.AddWithValue("id", id);
           
            if (sqlcommand.ExecuteNonQuery()>0)
                Console.WriteLine("Deleted");
            else
                Console.WriteLine($"Id-si {id} olan Student bazada yodur");
        }

        public void Update(int? id,Student student, string connectionString)
        {
            string query = @" UPDATE Students SET 
                        [Name] = CASE
                        WHEN @name IS NOT NULL THEN @name 
                        ELSE [Name] 
                     END,
                        Surname = CASE 
                        WHEN @surname IS NOT NULL THEN @surname 
                        ELSE Surname 
                     END
                      WHERE Id = @id"
            ;
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using SqlCommand sqlcommand = new SqlCommand(query, connection);
            sqlcommand.Parameters.AddWithValue("@name", (object?)student.Name ?? DBNull.Value);
            sqlcommand.Parameters.AddWithValue("@surname", (object?)student.Surname ?? DBNull.Value);
            sqlcommand.Parameters.AddWithValue("@id", id);

            if (sqlcommand.ExecuteNonQuery() > 0)
                Console.WriteLine("Updated");
            else
                Console.WriteLine($"Id-si {id} olan Student bazada yodur");
        }

        public List<string> GetAllNameVIEW(string connectionString)
        {
            List<string> data = new List<string>();
            string query = @"SELECT * FROM GetAllName";
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using SqlCommand sqlcommand = new SqlCommand(query, connection);
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    string name = (string)sqlDataReader.GetValue(0);
                    data.Add(name);
                }
            }
            else
                Console.WriteLine($"Student Name bazada yodur");
            return data;
        }

        public int GetCount(string connectionString)
        {   
            string query = @"SELECT dbo.GetCount()";
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using SqlCommand sqlcommand = new SqlCommand(query, connection);
            int result=(int)sqlcommand.ExecuteScalar();         
            return result;
        }

        public string GetCountry(int studentId,string connectionString)
        {
            string query = @"GetCountry";
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using SqlCommand sqlcommand = new SqlCommand(query, connection);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddWithValue("@StudentId", studentId);
            using SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            string adress;
            if (sqlDataReader.HasRows) 
            {
                while (sqlDataReader.Read()) 
                {
                    adress = (string)sqlDataReader.GetValue(0);
                    return adress;
                }
            }
            return null;
        }


        public void TestSqlDataReader(string connection)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            using (SqlCommand cmd=new SqlCommand("SELECT * FROM Students", sqlConnection))
            {
                sqlConnection.Open();   
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine($"{sqlDataReader["Id"]} {sqlDataReader["Name"]} {sqlDataReader["Surname"]}");
                        int id = (int)sqlDataReader.GetValue(0);
                        string name = (string)sqlDataReader.GetValue(1);
                        string surname = (string)sqlDataReader.GetValue(2);
                        Console.WriteLine($"{id} {name} {surname}");
                    }
                }

            }    
            
        }

        public void TestSqlDataAdapter(string connection)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Students", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine($"Ad: {row["Name"]}, Soyad: {row["Surname"]}");
                    Console.WriteLine($"Ad: {row[1]}, Soyad: {row[2]}");
                }
            }

        }

        public void TestDataSet(string connection)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Students; SELECT * FROM StudentDetails", conn);
                adapter.Fill(ds);
                DataTable studentsTable = ds.Tables[0];        // 1-ci cədvəl: Students
                DataTable studentDetailsTable = ds.Tables[1]; // 2-ci cədvəl: StudentDetails

                foreach (DataRow row in studentsTable.Rows)
                {
                    Console.WriteLine($"Ad: {row["Name"]}, Soyad: {row["Surname"]}");
                   // Console.WriteLine($"Ad: {row[1]}, Soyad: {row[2]}");
                }

                foreach (DataRow row in studentDetailsTable.Rows)
                {
                    Console.WriteLine($"Ad: {row["Address"]}, Soyad: {row["Email"]}");
                    //Console.WriteLine($"Ad: {row[1]}, Soyad: {row[2]}");
                }
            }

        }

        public void TestDataTable(string connection)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Age", typeof(int));

            table.Rows.Add("Ali", 25);
            table.Rows.Add("Veli", 30);

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"Ad: {row["Name"]}, Yaş: {row["Age"]}");
            }
        }

    }
}