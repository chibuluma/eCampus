using System;
using System.Collections.Generic;

namespace eCampus.DAL.Models
{
    public partial class Province
    {
        public Province()
        {
            Districts = new HashSet<District>();
            Institutions = new HashSet<Institution>();
        }

        public string ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public string CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
