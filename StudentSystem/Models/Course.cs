using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Course
    {
        // CourseId
        public int CourseId { get; set; }
        // Name(up to 80 characters, unicode)
        [MaxLength(80)]
        public string Name { get; set; }=null!;
        // Description(unicode, not required)
        public string? Description { get; set; }
        // StartDate
        public DateTime StartDate { get; set; }
        // EndDate
        public DateTime EndDate { get; set; }
        // Price
        public Double Price { get; set; }
        public List<Student> Students { get; set; }  
        public List<Homework> Homeworks { get; set; }
    }
}
