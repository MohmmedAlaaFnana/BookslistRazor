using BookslistRazor.Models;
using Microsoft.EntityFrameworkCore;


namespace BookslistRazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> ? Books { get; set; }
        public DbSet<Author> ? Authors { get; set; }
        public DbSet<Genre> ? Genres { get; set; }
        public DbSet<Publisher> ? Publishers { get; set; }
    }
}
