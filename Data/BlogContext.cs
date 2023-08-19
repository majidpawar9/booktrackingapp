using Microsoft.EntityFrameworkCore;
using booktrackingapp.Models;

namespace booktrackingapp.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) 
            : base(options)
        {
            // This constructor is used to configure the DbContext with the provided options.
        }
        // DbSet property to represent the "Books" table in the database.
        // The "= null!" ensures that it's initialized as non-null, even if it's not set in the constructor.
        public DbSet<Book> Books { get; set; } =null!;
        public DbSet<Category> Categories { get; set; } =null!;
        public DbSet<CategoryType> CategoryTypes { get; set; } =null!;

    }
}