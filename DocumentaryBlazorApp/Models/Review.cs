using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentaryBlazorApp.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; } // Auto-incremented by the database
        [Required(ErrorMessage = "A documentary must be selected.")]
        [ForeignKey("Documentary")]
        public int DocumentaryId { get; set; }
        [Range(1, 5, ErrorMessage = "Please enter a rating between 1 and 5.")]
        public int Rating { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DatePosted { get; set; } = DateTime.Now;
    }
}
