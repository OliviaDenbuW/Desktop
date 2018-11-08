namespace tentaUppg7.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lärare
    {
        public int LärareId { get; set; }

        [StringLength(12)]
        public string Personnummer { get; set; }

        public virtual Person Person { get; set; }
    }
}
