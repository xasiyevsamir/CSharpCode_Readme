using Academy.Core.Entities;
using Academy.Service.Services;

namespace Academy.App.Controllers
{
    internal class GroupController
    {
        public readonly GroupService groupService;
        public GroupController()
        {
            groupService = new GroupService();
        }

        public async Task Create()
        {
          await  groupService.CreateGroupAsync(new Group { No="Pb501", Limit=30, CreateDate=DateTime.Now});
        }

        public async Task GetAll()
        {         
            foreach (var group in await groupService.GetAllGroupAsync())
            {
                Console.WriteLine(group);
                Console.WriteLine("====================");
            }
        }

        public async Task GetAllWithNoAsync()
        {
            foreach (var group in await groupService.GetAllWithNoGroupAsync("1"))
            {
                Console.WriteLine(group);
                Console.WriteLine("====================");
            }
        }
    }
}
