using System;
using System.Collections.Generic;

namespace RoyalHospital.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public string Img { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? ImgHome { get; set; }
        public string? Description { get; set; }
    }
}
