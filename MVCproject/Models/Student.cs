using System;
using System.ComponentModel.DataAnnotations;

namespace MVCproject.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public DateTime CourseEnrolledDate { get; set; }
        [Required]
        public int CourseStatus { get; set; }
        
        [Required]
        public string Grade { get; set; }

        [Required]
        [Range(19, int.MaxValue, ErrorMessage = "Age must be greater than 18")]
        public int Age { get; set; }

    }
}