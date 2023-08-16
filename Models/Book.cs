using System.ComponentModel.DataAnnotations;

namespace booktrackingapp.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Author { get; set; }
        
        public Genre Genre { get; set; } // Assuming Genre is an enum or another entity
        
        // Other properties like publication date, rating, etc.
    }
    
    public enum Genre
    {
        Mystery,
        Fantasy,
        Romance,
        ScienceFiction,
        // Other genres
    }
}
