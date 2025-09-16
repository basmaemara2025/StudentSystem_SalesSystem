using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    enum ResourceType { Video, Presentation, Document, Other }
    public class Resource
    {
        //ResourceId
        public int ResourceId { get; set; }
        //Name(up to 50 characters, unicode)
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        //Url(not unicode)
        [Unicode(false)]
        public string? Url { get; set; }

        //ResourceType(enum – can be Video, Presentation, Document or Other)
        ResourceType ResourceType { get; set; }
        //CourseId
        public int CourseId { get; init; }
        public Course Course { get; set; }
        
    }
}
