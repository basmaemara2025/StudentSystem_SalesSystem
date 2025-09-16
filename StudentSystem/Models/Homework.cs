using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{ enum ContentType { Application, Pdf , Zip }
    public class Homework
    {
        // HomeworkId
        
        public int HomeworkId { get; set; }
        //Content(string, linking to a file, not unicode)
        [Unicode(false)]
        public string? Content { get; set; }

        //ContentType(enum – can be Application, Pdf or Zip)
        ContentType HWContentType { get; set; }
        // SubmissionTime
        public DateTime SubmissionTime { get; set; }
        // StudentId
        public int StudentId { get; set; }
       // CourseId
        public int CourseId { get; set; }

        public Course Course { get; set; }

    }
}
