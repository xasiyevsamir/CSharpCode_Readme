using Academy.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Academy.Core.Entities
{
    public class Student:BaseEntitie
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int GroupId { get; set; }

        public Group Group { get; set; }

        public PointName  PointName { get; set; }
    }
}
