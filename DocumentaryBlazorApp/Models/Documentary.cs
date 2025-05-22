using System.ComponentModel.DataAnnotations;

namespace DocumentaryBlazorApp.Models

{
    public class Documentary
    {
        [Range(1, int.MaxValue, ErrorMessage = "ID must be a positive integer")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Director name is required")]
        [StringLength(50, ErrorMessage = "Director name cannot exceed 50 characters")]
        public string Director { get; set; } = string.Empty;
        [Required(ErrorMessage = "Category is required")]
        [StringLength(30, ErrorMessage = "Category cannot exceed 30 characters")]
        public string Category { get; set; } = string.Empty;
        [Required(ErrorMessage = "Description is required")]
        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters")]
        public string Description { get; set; } = string.Empty;
        [Required(ErrorMessage = "Language is required")]
        [EnumDataType(typeof(Language), ErrorMessage = "Invalid language selection")]
        public Language Language { get; set; }
        [Required(ErrorMessage = "Duration is required")]
        [Range(1, 99999, ErrorMessage = "Duration must be between 1 and 600 minutes")]
        public int Duration { get; set; }
        [Required(ErrorMessage = "Year is required")]
        [Range(1900, 2100, ErrorMessage = "Year must be between 1900 and 2100")] // today !!!
        public int Year { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        [Url(ErrorMessage = "Invalid URL format")]
        [Display(Name = "Trailer URL")]
        public string TrailerUrl { get; set; } = string.Empty;

        [StringLength(9999, ErrorMessage = "Review cannot exceed 500 characters")]
        public string Review { get; set; } = string.Empty;
        public List<Review> Reviews { get; set; } = new();
    }
}