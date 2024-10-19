using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Models
{
    public class Student
    {
        [Key]
        public int StdId { get; set; }

        [Required] 
        [StringLength(100)] 
        public string StdName { get; set; }

        [Range(1, 150)] 
        public int StdAge { get; set; }

        [EmailAddress] 
        [Required] 
        [StringLength(150)] 
        public string StdEmail { get; set; }

        [StringLength(250)] 
        public string StdAddress { get; set; }
    }
}
