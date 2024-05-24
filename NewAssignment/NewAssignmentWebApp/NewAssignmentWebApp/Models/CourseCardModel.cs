﻿namespace NewAssignmentWebApp.Models
{
    public class CourseCardModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public int Hours { get; set; }
        public int? Likes { get; set; }
        public int? LikePercentage { get; set; }
        public bool IsBestSeller { get; set; } = false;
        public string ImageUrl { get; set; } = null!;
    }
}
