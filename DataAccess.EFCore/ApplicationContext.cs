using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccess.EFCore
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Series> Series { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookToSeries>().HasKey(ba => new { ba.BookId, ba.SeriesId });

            modelBuilder.Entity<BookToSeries>().HasOne(b => b.Book)
                .WithMany(bs => bs.Series)
                .HasForeignKey(o => o.BookId).IsRequired(false); 

            modelBuilder.Entity<BookToSeries>()
                .HasOne(s => s.Series)
                .WithMany(b => b.Books)
                .HasForeignKey(o => o.SeriesId).IsRequired(false);
        }
    }
}
