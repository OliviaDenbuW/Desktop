using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OliviaDemoASPNETEntityFramework.Models
{
    public partial class MyDBContext : DbContext
    {
        public virtual DbSet<Person> Person { get; set; }
     
        public MyDBContext(DbContextOptions<MyDBContext> options)
        : base(options)
        { }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=localhost; Database=MyDB ;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
