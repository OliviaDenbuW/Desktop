using System;
using System.Collections.Generic;

namespace BloggOliviasVärldInlämning1.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Posts = new HashSet<Posts>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Posts> Posts { get; set; }
    }
}
