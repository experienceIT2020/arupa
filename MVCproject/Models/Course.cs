using System.ComponentModel.DataAnnotations;

namespace MVCproject.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string CourseDescription { get; set; }
        [Required]
        public string TutorName { get; set; }
        [Range(1, 10, ErrorMessage = "Range must be between 1 to 10")]
        public int CourseRating { get; set; }

    }
}