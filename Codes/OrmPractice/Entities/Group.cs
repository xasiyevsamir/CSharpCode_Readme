
using Azure;
using OrmPractice.Enum;

namespace OrmPractice.Entities
{
    internal class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int MinCount { get; set; }

        public int MaxCount { get; set; }

        public int ActivCount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Student> Students { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}\nName:{Name}\nMinCount:{MinCount}\nMaxCount:{MaxCount}\nActivCount:{ActivCount}\nStartDate:{StartDate}\nEndDate:{EndDate}\n=========================";
        }
    }
}
