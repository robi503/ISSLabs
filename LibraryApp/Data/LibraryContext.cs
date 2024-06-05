using LibraryApp.Model;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Data
{
    public class LibraryContext(DbContextOptions<LibraryContext> options) : DbContext(options)
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Borrowment> Borrowments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(b => b.Id);
            });

            modelBuilder.Entity<Librarian>(entity =>
            {
                entity.HasKey(l => l.Username);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(c => c.Username);

            });

            modelBuilder.Entity<Borrowment>(entity =>
            {
                entity.HasKey(b => b.Id);
            });
        }
    }
}
