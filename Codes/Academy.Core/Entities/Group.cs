namespace Academy.Core.Entities
{
    public class Group:BaseEntitie
    {
        public string No { get; set; }

        public int Limit { get; set; }

        public DateTime CreateDate { get; set; }

        public List<Student> Students { get; set; }
    }
}
