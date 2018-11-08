using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BloggOliviasVärldInlämning1.Models
{
    public partial class Posts
    {

        public int PostId { get; set; }

        [DisplayName("Headline")]
        [StringLength (50, ErrorMessage = "Rubrik får inte vara längre än 50 tecken")]
        [Required(ErrorMessage = "Rubrik på inlägget är obligatoriskt")]
        public string HeadLine { get; set; }

        [DisplayName("Breadtext")]
        [StringLength(2000, ErrorMessage = "Brödtext får inte vara längre än 2000 tecken")]
        public string BreadText { get; set; }

        public int CategoryId { get; set; }

        public DateTime DatePosted { get; set; }

        public Categories Category { get; set; }
    }
}
