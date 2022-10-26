using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Concurrent;

namespace Labb1_MVCAndRazor.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerID = 1, CustomerName = "Jack", CustomerEmail = "jack@jack.com", CustomerPhone = "070551112244" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerID = 2, CustomerName = "Emma", CustomerEmail = "emma@emma.com", CustomerPhone = "07111222333" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerID = 3, CustomerName = "Timothy", CustomerEmail = "timothy@timothy.com", CustomerPhone = "070123123123" });

            modelBuilder.Entity<Book>().HasData(new Book { BookID = 1, Title = "Lord of the Rings" });
            modelBuilder.Entity<Book>().HasData(new Book { BookID = 2, Title = "Harry Potter" });
            modelBuilder.Entity<Book>().HasData(new Book { BookID = 3, Title = "Hitchikers guide to the Galaxy" });
            modelBuilder.Entity<Book>().HasData(new Book { BookID = 4, Title = "Minecraft: Building and Fighting Vol. 3" });

            modelBuilder.Entity<Loan>().HasData(new Loan { LoanID = 1, BookID = 1, CustomerID = 1, IsReturned = false });
        }


    }
}
