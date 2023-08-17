using System.ComponentModel.DataAnnotations;

namespace booktrackingapp.Models
{
    public class CategoryType
    {
        [Key]
        public string Type { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}
