using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OliviaDemoArkitektur.Models
{
    public partial class DemoArkitekturDbContext : DbContext
    {
        public DemoArkitekturDbContext()
        {
        }

        public DemoArkitekturDbContext(DbContextOptions<DemoArkitekturDbContext> options)
            : base(options)
        {
        }

        // Unable to generate entity type for table 'dbo.Person'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=DemoArkitekturDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
