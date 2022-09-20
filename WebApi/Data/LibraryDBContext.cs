using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApi.Data
{
    public partial class LibraryDBContext : DbContext
    {
        public LibraryDBContext()
        {
        }

        public LibraryDBContext(DbContextOptions<LibraryDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Integrated Security=True; Database=LibraryDB");
            }
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Book MHAvol1 = new Book() {Id=1, language = "Japanese", title = "My Hero Academia Vol.1", author_romanized = "Kohei Horikoshi", coverImg = "https://www.sfbok.se/sites/default/files/styles/1000x/sfbok/sfbokbilder/147/147700.jpg?bust=1440759673&itok=D2XWJEaX" };
            //modelBuilder.Entity<Book>().HasData(MHAvol1);
            
            
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
