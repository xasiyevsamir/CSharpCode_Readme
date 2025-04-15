using Academy.App.Controllers;

namespace Academy.App
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            GroupController groupController = new GroupController();
            StudentController studentController = new StudentController();
            // await groupController.Create();

            // await groupController.GetAll();

            //  await groupController.GetAllWithNoAsync();

            //  await  studentController.StudentCreate();

              await  studentController.StudentUpdateAsync();

        }
    }
}
