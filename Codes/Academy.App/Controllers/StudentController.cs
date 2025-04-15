using Academy.Core.Entities;
using Academy.Core.Enums;
using Academy.Service.Services;

namespace Academy.App.Controllers
{
    internal class StudentController
    {
        public readonly StudentService studentService;
        public StudentController()
        {
            studentService = new StudentService();
        }

        public async Task StudentCreateAsync()
        {

          await  studentService.CreateStudentAsync(new Student { Name="Rasim", Age=30, PointName=PointName.B},1);
        }

        public async Task StudentUpdateAsync()
        {

            await studentService.UpdateByIdStudentAsync(5,new Student { Name ="Rasim", Age = 20, PointName = PointName.B },1);
        }
    }
}
