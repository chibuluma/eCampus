using System;
using System.Collections.Generic;

namespace eCampus.DAL.Models
{
    public partial class Institution
    {
        public Institution()
        {
            Lecturers = new HashSet<Lecturer>();
            Programmes = new HashSet<Programme>();
            Schools = new HashSet<School>();
        }

        public string InstitutionId { get; set; }
        public string InstitutionName { get; set; }
        public string CountryId { get; set; }
        public string ProvinceId { get; set; }
        public string DistrictId { get; set; }

        public virtual Country Country { get; set; }
        public virtual District District { get; set; }
        public virtual Province Province { get; set; }
        public virtual ICollection<Lecturer> Lecturers { get; set; }
        public virtual ICollection<Programme> Programmes { get; set; }
        public virtual ICollection<School> Schools { get; set; }
    }
}
