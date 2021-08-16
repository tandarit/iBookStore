using iBookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBookStore.DataContext
{
    public class ShopDataContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<BookFormat> BookFormats { get; set; }
        public DbSet<BookFormatBook> BookFormatBooks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\bookwebstore.db");
            //optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookFormatBook>()
                .HasKey(bc => new { bc.BookId, bc.BookFormatId });
            modelBuilder.Entity<BookFormatBook>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookFormatBooks)
                .HasForeignKey(bc => bc.BookId);
            modelBuilder.Entity<BookFormatBook>()
                .HasOne(bc => bc.BookFormat)
                .WithMany(c => c.BookFormatBooks)
                .HasForeignKey(bc => bc.BookFormatId);



            modelBuilder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookId, bc.CategoryId });
            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.BookId);
            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BookCategories)
                .HasForeignKey(bc => bc.CategoryId);



            modelBuilder.Entity<BookAuthor>()
               .HasKey(bc => new { bc.BookId, bc.AuthorId });
            modelBuilder.Entity<BookAuthor>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(bc => bc.BookId);
            modelBuilder.Entity<BookAuthor>()
                .HasOne(bc => bc.Author)
                .WithMany(c => c.BookAuthors)
                .HasForeignKey(bc => bc.AuthorId);



            modelBuilder.Entity<Book>().HasOne(a => a.Publisher).WithMany(b => b.Books).OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
