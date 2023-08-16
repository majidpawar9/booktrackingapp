using Microsoft.EntityFrameworkCore;
using booktrackingapp.Models;

namespace booktrackingapp.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) 
            : base(options)
        {

        }

        public DbSet<Book> Books { get; set; } =null!;

    }
}