using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace uppg2FormulärModellEF.Models
{
    public partial class LoginDBContext : DbContext
    {
        public virtual DbSet<UserLogin> UserLogin { get; set; }

        public LoginDBContext(DbContextOptions<LoginDBContext> options)
        : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=localhost; Database=LoginDB ;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.Password).HasMaxLength(20);
            });
        }
    }
}
