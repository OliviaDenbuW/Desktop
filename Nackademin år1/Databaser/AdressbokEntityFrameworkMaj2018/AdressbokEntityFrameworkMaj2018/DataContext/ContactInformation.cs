namespace AdressbokEntityFrameworkMaj2018.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactInformation")]
    public partial class ContactInformation
    {
        [Key]
        public int ContactID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string StreetName { get; set; }

        public int ZipCode { get; set; }

        [Required]
        [StringLength(30)]
        public string PostalArea { get; set; }

        public int PhoneNumber { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        public int TypeOfContactID { get; set; }

        public virtual ContactType ContactType { get; set; }
    }
}
