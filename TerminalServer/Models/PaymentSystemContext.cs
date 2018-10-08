using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace TerminalServer.Models
{
    public class PaymentSystemContext : DbContext
    {
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Terminal> Terminals { get; set; }

        
        public PaymentSystemContext(DbContextOptions<PaymentSystemContext> options)
           : base(options)
        {
            //Database.EnsureCreated();
        }
        

        public PaymentSystemContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // использование Fluent API
            modelBuilder.Entity<Seller>().ToTable("Seller");
            modelBuilder.Entity<Terminal>().ToTable("Terminal");
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Terminal>()
        .HasKey(lc => new { lc.Seller });
        }


    }
}
