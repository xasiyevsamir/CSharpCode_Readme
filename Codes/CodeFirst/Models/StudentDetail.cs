namespace CodeFirst.Models
{
    internal class StudentDetail
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; } 
    }
}
