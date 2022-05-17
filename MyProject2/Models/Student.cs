using System.ComponentModel.DataAnnotations;

namespace MyProject2.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }




    }
}
