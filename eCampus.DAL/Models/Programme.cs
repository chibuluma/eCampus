using System;
using System.Collections.Generic;

namespace eCampus.DAL.Models
{
    public partial class Programme
    {
        public Programme()
        {
            Courses = new HashSet<Course>();
            Departments = new HashSet<Department>();
        }

        public string ProgrammeId { get; set; }
        public string ProgrammeCode { get; set; }
        public string ProgrammeDescription { get; set; }
        public string InstitutionId { get; set; }

        public virtual Institution Institution { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
