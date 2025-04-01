namespace CodeFirst.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group  { get; set; }
        public List<StudentCourse> StudentCourse { get; set; }
    }
}
