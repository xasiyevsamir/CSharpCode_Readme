using Academy.Core.Entities;

namespace Academy.Service.Interfaces
{
    public interface IStudentService
    {
        void CreateStudent(Student student, int groupId);
        Task CreateStudentAsync(Student student, int groupId);
        void DeleteByIdGroup(int? id);
        Task DeleteByIdGroupAsync(int? id);
        List<Student> GetAllStudents();
        Task<List<Student>> GetAllStudentsAsync();
        List<Student> GetAllWithNameStudent(string value);
        Task<List<Student>> GetAllWithNameStudentAsync(string value);
        Student GetByIdStudent(int? id);
        Task<Student> GetByIdStudentAsync(int? id);
        void UpdateByIdStudent(int? id, Student student, int? groupId);
        Task UpdateByIdStudentAsync(int? id, Student student, int? groupId);
    }
}