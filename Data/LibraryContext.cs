using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using website.Models;

    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<website.Models.Author> Author { get; set; }

        public DbSet<website.Models.Book> Book { get; set; }

        public DbSet<website.Models.Instructor> Instructor { get; set; }
    }
