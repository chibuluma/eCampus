using System;
using System.Collections.Generic;

namespace eCampus.DAL.Models
{
    public partial class Country
    {
        public Country()
        {
            Districts = new HashSet<District>();
            Institutions = new HashSet<Institution>();
            Provinces = new HashSet<Province>();
        }

        public string CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<Institution> Institutions { get; set; }
        public virtual ICollection<Province> Provinces { get; set; }
    }
}
