using System;
using System.Collections.Generic;

namespace eCampus.DAL.Models
{
    public partial class Lecturer
    {
        public string LecturerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Nrc { get; set; }
        public string PassportNo { get; set; }
        public string SchoolId { get; set; }
        public string DepartmentId { get; set; }
        public string InstitutionId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Institution Institution { get; set; }
        public virtual School School { get; set; }
    }
}
