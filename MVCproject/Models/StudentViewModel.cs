using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCproject.Models
{
    public class StudentViewModel 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public int CourseId { get; set; }

        public string CourseName { get; set; }
        [Required]
        public DateTime CourseEnrolledDate { get; set; }
        [Required]
        public int CourseStatus { get; set; }

        public string CourseStatusName { get; set; }

        [Required]
        public string Grade { get; set; }

        [Required]
        [Range(18, int.MaxValue)]
        public string Age { get; set; }
        public IList<MVCproject.Models.Course> Courses { get; set; }
    }
}