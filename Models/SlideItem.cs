using System;
using System.Collections.Generic;

namespace RoyalHospital.Models
{
    public partial class SlideItem
    {
        public int Id { get; set; }
        public string Img { get; set; } = null!;
        public string? Title { get; set; }
        public string YoutubeLink { get; set; } = null!;
    }
}
