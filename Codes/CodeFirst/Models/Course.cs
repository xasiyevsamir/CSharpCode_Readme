namespace CodeFirst.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StudentCourse> StudentCourse { get; set; }

    }
}
