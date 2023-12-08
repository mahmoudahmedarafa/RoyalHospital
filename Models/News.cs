using System;
using System.Collections.Generic;

namespace RoyalHospital.Models
{
    public partial class News
    {
        public int Id { get; set; }
        public string Img { get; set; } = null!;
        public string Date { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? Selector { get; set; }
        public string? ImgHome { get; set; }
    }
}
