namespace Sql_Connection.Services
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nAddress:{Address}\nEmail:{Email}\n_____________________";
        }
    }
}
