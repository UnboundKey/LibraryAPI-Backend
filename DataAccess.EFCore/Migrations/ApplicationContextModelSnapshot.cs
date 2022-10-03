﻿// <auto-generated />
using DataAccess.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.EFCore.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("author_romanized")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bookType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("coverImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("firstPrinted")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("original_title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("printing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("short_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Domain.Entities.BookToSeries", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("SeriesId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "SeriesId");

                    b.HasIndex("SeriesId");

                    b.ToTable("BookToSeries");
                });

            modelBuilder.Entity("Domain.Entities.Series", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logoImg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("Domain.Entities.BookToSeries", b =>
                {
                    b.HasOne("Domain.Entities.Book", "Book")
                        .WithMany("Series")
                        .HasForeignKey("BookId");

                    b.HasOne("Domain.Entities.Series", "Series")
                        .WithMany("Books")
                        .HasForeignKey("SeriesId");

                    b.Navigation("Book");

                    b.Navigation("Series");
                });

            modelBuilder.Entity("Domain.Entities.Book", b =>
                {
                    b.Navigation("Series");
                });

            modelBuilder.Entity("Domain.Entities.Series", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
