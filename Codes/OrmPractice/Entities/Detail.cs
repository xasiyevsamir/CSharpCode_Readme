using Azure;
using OrmPractice.Enum;

namespace OrmPractice.Entities
{
    internal class Detail
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }


        public override string ToString()
        {
            return $"Id:{Id}\nEmail:{Email}\nAddress:{Address}\n=========================";
        }
    }
}
