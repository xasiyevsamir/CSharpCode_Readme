using Academy.Core.Entities;
using Academy.DataAccess.Data;
using Academy.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Academy.Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly AcademyDbContext _context;
        private readonly GroupService groupService;
        public StudentService()
        {
            _context = new AcademyDbContext();
            groupService = new GroupService();
        }


        public List<Student> GetAllStudents() =>
            _context.Students.AsNoTracking()
            .Include(s => s.Group)
            .ToList();

        public async Task<List<Student>> GetAllStudentsAsync() =>
           await _context.Students.AsNoTracking()
            .Include(s => s.Group)
            .ToListAsync();

        public Student GetByIdStudent(int? id)
        {
            if (id is null)
                throw new Exception("Id is null");
            return _context.Students.Include(s => s.Group).FirstOrDefault(s => s.Id == id) ??
                throw new Exception("Student not found with Id");
        }

        public async Task<Student> GetByIdStudentAsync(int? id)
        {
            if (id is null)
                throw new Exception("Id is null");
            return await _context.Students.Include(s => s.Group).FirstOrDefaultAsync(s => s.Id == id) ??
                throw new Exception("Student not found with Id");
        }


        public List<Student> GetAllWithNameStudent(string value) =>
           _context.Students.AsNoTracking().Include(s => s.Group)
           .Where(g => g.Name.Contains(value))
           .ToList();

        public async Task<List<Student>> GetAllWithNameStudentAsync(string value) =>
           await _context.Students.AsNoTracking().Include(s => s.Group)
            .Where(g => g.Name.Contains(value))
            .ToListAsync();

        public void DeleteByIdGroup(int? id)
        {
            var removeStudent = GetByIdStudent(id);
            _context.Students.Remove(removeStudent);
            _context.SaveChanges();
        }

        public async Task DeleteByIdGroupAsync(int? id)
        {
            var removeStudent = await GetByIdStudentAsync(id);
            _context.Students.Remove(removeStudent);
            await _context.SaveChangesAsync();
        }

        public void UpdateByIdStudent(int? id, Student student, int? groupId)
        {
            Student existstudent = GetByIdStudent(id);
            Group existgroup = groupService.GetByIdGroup(groupId);
            if (existstudent.GroupId != groupId)
            {
                if (existgroup.Students.Count >= existgroup.Limit)
                    throw new Exception("Group is full");
            }
            existstudent.GroupId = groupId ?? existstudent.GroupId;
            existstudent.Name = student.Name ?? existstudent.Name;
            existstudent.PointName = student.PointName;
            _context.SaveChanges();
        }

        public async Task UpdateByIdStudentAsync(int? id, Student student, int? groupId)
        {
            Student existstudent = await GetByIdStudentAsync(id);
            Group existgroup = await groupService.GetByIdGroupAsync(groupId);
            if (existstudent.GroupId != groupId)
            {
                if (existgroup.Students.Count >= existgroup.Limit)
                    throw new Exception("Group is full");
            }
            existstudent.GroupId = groupId ?? existstudent.GroupId;
            existstudent.Name = student.Name ?? existstudent.Name;
            existstudent.PointName = student.PointName;
            existstudent.Age = student.Age;
            await _context.SaveChangesAsync();
        }

        public void CreateStudent(Student student, int groupId)
        {
            Group existgroup = groupService.GetByIdGroup(groupId);

            if (existgroup.Students.Count >= existgroup.Limit)
                throw new Exception("Group is full");
            student.GroupId = groupId;
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public async Task CreateStudentAsync(Student student, int groupId)
        {
            Group existgroup = await groupService.GetByIdGroupAsync(groupId);
            if (existgroup.Students.Count >= existgroup.Limit)
                throw new Exception("Group is full");
            student.GroupId=groupId;
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }
    }
}
