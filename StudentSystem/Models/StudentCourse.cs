using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    [PrimaryKey(nameof(StudentId),nameof(CourseId))]
    public class StudentCourse
    {
        //mapping class between Students and Courses
        public int StudentId { get; set; }
        public Student student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
