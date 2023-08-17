using System.ComponentModel.DataAnnotations;

namespace booktrackingapp.Models
{
    public class Category
    {
        [Key] // This marks the NameToken property as the primary key
        public string NameToken { get; set; }
        
        [Required]
        public int TypeId { get; set; } // Foreign key to CategoryType
        public CategoryType Type { get; set; } // Navigation property to CategoryType
        
        public string Description { get; set; }

    }
}
