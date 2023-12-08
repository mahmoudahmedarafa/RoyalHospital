using System;
using System.Collections.Generic;

namespace RoyalHospital.Models
{
    public partial class Clinic
    {
        public Clinic()
        {
            Doctors = new HashSet<Doctor>();
        }

        public int Id { get; set; }
        public string Img { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
