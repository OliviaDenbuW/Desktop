using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Uppg1Layout.Models
{
    public partial class NackademinContext : DbContext
    {
        public virtual DbSet<Utbildningar> Utbildning { get; set; }

        public NackademinContext(DbContextOptions<NackademinContext> options)
        : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=localhost; Database=Nackademin ;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utbildningar>(entity =>
            {
                entity.HasKey(e => e.UtbildningsId);

                entity.Property(e => e.UtbildningsId).HasColumnName("UtbildningsID");

                entity.Property(e => e.Beskrivning).HasMaxLength(500);

                entity.Property(e => e.Namn).HasMaxLength(50);
            });
        }
    }
}
