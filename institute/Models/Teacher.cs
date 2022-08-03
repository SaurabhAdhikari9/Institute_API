using System.ComponentModel.DataAnnotations;

namespace institute.Models
{
    public class Teacher
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        [Required]
        public long ContactNo { get; set; }
    }
}
