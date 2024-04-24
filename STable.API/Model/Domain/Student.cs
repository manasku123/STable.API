using System.ComponentModel.DataAnnotations;

namespace STable.API.Model.Domain
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? StudentClass { get; set; }
    }
}
