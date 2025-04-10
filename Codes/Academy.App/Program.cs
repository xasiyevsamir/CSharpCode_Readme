using Academy.App.Controllers;
using Academy.Service.Services;

namespace Academy.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentController studentController = new StudentController();
            studentController.StudentCreate();
        }
    }
}
