using Academy.Core.Entities;
using Academy.DataAccess.Data;
using Academy.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Academy.Service.Services
{
    public class GroupService : IGroupService
    {
        private readonly AcademyDbContext _context;
        public GroupService()
        {
            _context = new AcademyDbContext();
        }

        public void CreateGroup(Group group)
        {
            if (_context.Groups.Any(g => g.No == group.No))
                throw new Exception("Eyni adda group ola bilmez");
            _context.Groups.Add(group);
            _context.SaveChanges();
        }

        public async Task CreateGroupAsync(Group group)
        {
            if (await _context.Groups.AnyAsync(g => g.No == group.No))
                throw new Exception("Eyni adda group ola bilmez");
            await _context.Groups.AddAsync(group);
            await _context.SaveChangesAsync();
        }

        public List<Group> GetAllGroup() => _context.Groups.AsNoTracking().Include(g => g.Students).ToList();

        public async Task<List<Group>> GetAllGroupAsync() => await _context.Groups.AsNoTracking().Include(g => g.Students).ToListAsync();

        public List<Group> GetAllWithNoGroup(string value) =>
            _context.Groups.AsNoTracking().Include(g => g.Students)
            .Where(g => g.No.Contains(value))
            .ToList();

        public async Task<List<Group>> GetAllWithNoGroupAsync(string value) =>
           await _context.Groups.AsNoTracking().Include(g => g.Students)
            .Where(g => g.No.Contains(value))
            .ToListAsync();


        public Group GetByIdGroup(int? id)
        {
            if (id is null)
                throw new Exception("Id is null");
            return _context.Groups.Include(g => g.Students).FirstOrDefault(g => g.Id == id) ??
                throw new Exception("Group not found with Id");
        }

        public async Task<Group> GetByIdGroupAsync(int? id)
        {
            if (id is null)
                throw new Exception("Id is null");
            return await _context.Groups.Include(g => g.Students).FirstOrDefaultAsync(g => g.Id == id) ??
                throw new Exception("Group not found with Id");
        }


        public void DeleteByIdGroup(int? id)
        {
            var removegroup = GetByIdGroup(id);
            _context.Groups.Remove(removegroup);
            _context.SaveChanges();
        }

        public async Task DeleteByIdGroupAsync(int? id)
        {
            var removegroup = await GetByIdGroupAsync(id);
            _context.Groups.Remove(removegroup);
            await _context.SaveChangesAsync();
        }

        public void UpdateByIdGroup(int? id, Group group)
        {
            var updategroup = GetByIdGroup(id);

            if (_context.Groups.Any(g => g.No == group.No && g.Id!=id))
                throw new Exception("Eyni adda group ola bilmez");

            updategroup.No = group.No;
            updategroup.Limit = group.Limit;
            _context.SaveChanges();
        }

        public async Task UpdateByIdGroupAsync(int? id, Group group)
        {
            var updategroup = await GetByIdGroupAsync(id);

            if ( await _context.Groups.AnyAsync(g => g.No == group.No && g.Id != id))
                throw new Exception("Eyni adda group ola bilmez");
            updategroup.No = group.No ?? updategroup.No;
            updategroup.Limit = group.Limit;
            await _context.SaveChangesAsync();
        }
    }
}
