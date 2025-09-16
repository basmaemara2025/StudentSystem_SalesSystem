using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public  class Student
    {
        public int StudentId { get; set; }
        
        // Name(up to 100 characters, unicode)
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        //PhoneNumber (exactly 10 characters, not unicode, not required)
        [MaxLength(10)]
        [Unicode(false)]
        public string? PhoneNumber { get; set; }
        //RegisteredOn (DateTime)
        public DateTime RegisteredOn { get; set; }
        //Birthday (not required)
        public DateTime? Birthday { get; set; }

        public List<Course> Courses { get; set; }


    }
}
