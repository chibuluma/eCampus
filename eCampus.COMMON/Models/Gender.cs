using System;
using System.Collections.Generic;

namespace eCampus.DAL.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Students = new HashSet<Student>();
        }

        public string GenderId { get; set; }
        public string GenderDescription { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
