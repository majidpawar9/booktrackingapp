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
        
        public Genre Genre { get; set; } 
        
    }
    
    public enum Genre
    {
        Mystery,
        Fantasy,
        Romance,
        ScienceFiction,
    }
}
