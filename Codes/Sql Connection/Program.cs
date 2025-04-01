using Sql_Connection.Models;
using Sql_Connection.Services;
using System.Data.SqlClient;
using System.Data;

namespace Sql_Connection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ado Net");

            //AdoNet
            // Download package  <PackageReference Include="System.Data.SqlClient" Version="4.9.0" />
            string connectionString = "Server=.; Database=AdoNet; User=sa; Password=Salam123@;TrustServerCertificate=True";

            DatabaseService databaseService = new DatabaseService();
            CreateTableService createTableService = new CreateTableService();
            StudentService studentService = new StudentService();

            //Table yaratmaq
            createTableService.StudentsCreateTable(connectionString);
            createTableService.StudentDetailsCreateTable(connectionString);

            //Student yaratmaq
            studentService.CreateStudentAndDetail
                (
                  new Student { Name = "Elnur", Surname = "Axmedov" },
                  new StudentDetail { Email = "axmedovelnur404@gmail.com", Address = "Sumqayıt" },
                  connectionString
                );

            //Bütün Students baxmaq
            foreach (var student in studentService.GetAllStudent(connectionString))
            {
                Console.WriteLine(student);
            }

            // Id-yə uyğun Student-ə baxmaq
            Console.WriteLine(studentService.GetByIdStudent(3, connectionString));

            // Id-yə uyğun Student-i silmək
            studentService.Delete(2, connectionString);

            //Student Update etmək
            studentService.Update(1002,new Student() { Name="Elnur" },connectionString);

            //SQL də yazılmış VIEW ilə yalnız Student Name gətiririk
            foreach (var studentName in studentService.GetAllNameVIEW(connectionString))
               Console.WriteLine(studentName);

            //SQL də yazılmış FUNCTION ilə yalnız Student sayını gətiririk
            Console.WriteLine(studentService.GetCount(connectionString));

            //SQL də yazılmış PROCEDURE ilə yalnız Student Adress-ini gətiririk
            Console.WriteLine(studentService.GetCountry(1, connectionString));

            // SqlDataReader Test etmək..
            studentService.TestSqlDataReader(connectionString);

            // SqlDataAdapter Test etmək..
            studentService.TestSqlDataAdapter(connectionString);

            // Birdən çox cədvəli (DataTable) saxlamaq üçün.
             studentService.TestDataSet(connectionString);

            // Tək cədvəl məlumatlarını yaddaşda saxlamaq üçün.
            studentService.TestDataTable(connectionString);
        }
    }
}
