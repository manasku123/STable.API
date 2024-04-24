using System.ComponentModel.DataAnnotations;

namespace STable.API.Model.Domain
{
    public class Result
    {
        [Key]
        public int MarkSheetId {  get; set; }
        public string? SubjectName { get; set;}
        public int Totalmark { get; set;}
        public Guid StudentId { get; set;}

        public Student Student { get; set;}
    }
}
