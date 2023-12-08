using System;
using System.Collections.Generic;

namespace RoyalHospital.Models
{
    public partial class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Schedule { get; set; }
        public int? ClinicId { get; set; }
        public string? Img { get; set; }

        public virtual Clinic? Clinic { get; set; }
    }
}
