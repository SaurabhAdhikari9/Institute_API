using System.ComponentModel.DataAnnotations;

namespace institute.Models
{

    public class Student
    {
        [Required]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Address { get; set; }
        [Required]
        public string Faculty { get; set; }
        public string Email { get; set; }
    }

}
