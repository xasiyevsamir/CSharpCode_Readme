using Academy.Core.Entities;

namespace Academy.Service.Interfaces
{
    public interface IGroupService
    {
        void CreateGroup(Group group);
        Task CreateGroupAsync(Group group);
        void DeleteByIdGroup(int? id);
        Task DeleteByIdGroupAsync(int? id);
        List<Group> GetAllGroup();
        Task<List<Group>> GetAllGroupAsync();
        List<Group> GetAllWithNoGroup(string value);
        Task<List<Group>> GetAllWithNoGroupAsync(string value);
        Group GetByIdGroup(int? id);
        Task<Group> GetByIdGroupAsync(int? id);
        void UpdateByIdGroup(int? id, Group group);
        Task UpdateByIdGroupAsync(int? id, Group group);
    }
}