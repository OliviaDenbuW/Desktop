namespace AdressbokEntityFrameworkMaj2018.DataContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=AddressContext")
        {
        }

        public virtual DbSet<ContactInformation> ContactInformation { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactType>()
                .HasMany(e => e.ContactInformation)
                .WithRequired(e => e.ContactType)
                .HasForeignKey(e => e.TypeOfContactID)
                .WillCascadeOnDelete(false);
        }
    }
}
