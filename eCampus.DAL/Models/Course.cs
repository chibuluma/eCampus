using System;
using System.Collections.Generic;

namespace eCampus.DAL.Models
{
    public partial class Course
    {
        public string CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public string ProgrammeId { get; set; }

        public virtual Programme Programme { get; set; }
    }
}
