using System;
using System.Collections.Generic;

namespace eCampus.DAL.Models
{
    public class Student 
    {
        public string StudentId { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Nrc { get; set; }
        public string GenderId { get; set; }
        public DateTime Dob { get; set; }

        public virtual Gender Gender { get; set; }
    }
}
