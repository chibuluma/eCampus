using System.Collections.Generic;

namespace eCampus.DAL.Models
{
    public class School
    {
        public School()
        {
            Lecturers = new HashSet<Lecturer>();
            Departments = new HashSet<Department>();
        }

        public string SchoolId { get; set; }
        public string SchoolCode { get; set; }
        public string SchoolDescription { get; set; }
        public string InstitutionId { get; set; }

        public virtual Institution Institution { get; set; }
        public virtual ICollection<Lecturer> Lecturers { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
