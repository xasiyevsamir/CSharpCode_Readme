using CodeFirst.Models;

namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentDetail studentDetail = new StudentDetail();
            studentDetail.Email = "test@gmail.com";
            studentDetail.Student.Name = "Test";
        }
    }
}
