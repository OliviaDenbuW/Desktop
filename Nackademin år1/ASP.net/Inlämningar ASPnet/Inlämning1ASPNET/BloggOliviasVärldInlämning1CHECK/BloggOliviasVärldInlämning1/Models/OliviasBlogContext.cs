using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BloggOliviasVärldInlämning1.Models
{
    public partial class OliviasBlogContext : DbContext
    {
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }

        public OliviasBlogContext(DbContextOptions<OliviasBlogContext> options)
        : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=localhost; Database=OliviasBlog ;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.PostId);

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.BreadText)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.DatePosted)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HeadLine)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Posts__CategoryI__3A81B327");
            });
        }
    }
}
