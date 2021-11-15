using System;
using System.Collections.Generic;

namespace eCampus.DAL.Models
{
    public partial class Department
    {
        public Department()
        {
            Lecturers = new HashSet<Lecturer>();
        }

        public string DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentDescription { get; set; }
        public string ProgrammeId { get; set; }
        public string SchoolId { get; set; }

        public virtual Programme Programme { get; set; }
        public virtual ICollection<Lecturer> Lecturers { get; set; }
    }
}
