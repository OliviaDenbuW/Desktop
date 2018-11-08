namespace omtentaUppg4EnitityFramework.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int StudentId { get; set; }

        [StringLength(3)]
        public string Slutbetyg { get; set; }

        [StringLength(12)]
        public string Personnummer { get; set; }

        public virtual Person Person { get; set; }
    }
}
