using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoASPNETEntityFramework.Models
{
    //Context klass som hanterar en connection mot databasen
    public partial class MyDBContext : DbContext
    {
        public virtual DbSet<Person> Person { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options)
             : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
