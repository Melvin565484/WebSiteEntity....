﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace website.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("website.Models.Author", b =>
                {
                    b.Property<int>("authorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("addres")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("authorID");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("website.Models.Book", b =>
                {
                    b.Property<int>("bookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("authorID")
                        .HasColumnType("int");

                    b.Property<string>("publishedate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("subtitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("bookID");

                    b.HasIndex("authorID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("website.Models.Instructor", b =>
                {
                    b.Property<int>("InstructorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("certificate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("InstructorID");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("website.Models.Book", b =>
                {
                    b.HasOne("website.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("authorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("website.Models.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
