using System;
using System.Collections.Generic;

namespace eCampus.DAL.Models
{
    public partial class District
    {
        public District()
        {
            Institutions = new HashSet<Institution>();
        }

        public string DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string ProvinceId { get; set; }
        public string CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual Province Province { get; set; }
        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
