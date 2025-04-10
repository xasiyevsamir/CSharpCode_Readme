using Academy.Service.Services;

namespace Academy.App.Controllers
{
    internal class StudentController
    {
        public void StudentCreate()
        {
            StudentService studentService = new StudentService();

            studentService.Create();
        }
    }
}
