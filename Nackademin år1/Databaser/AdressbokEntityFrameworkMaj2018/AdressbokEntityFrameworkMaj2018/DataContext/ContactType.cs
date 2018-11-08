namespace AdressbokEntityFrameworkMaj2018.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactType")]
    public partial class ContactType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContactType()
        {
            ContactInformation = new HashSet<ContactInformation>();
        }

        [Key]
        public int TypeID { get; set; }

        [Required]
        [StringLength(15)]
        public string RelationType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactInformation> ContactInformation { get; set; }
    }
}
