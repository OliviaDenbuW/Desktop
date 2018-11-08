using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContext
{
    public class Resume
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool FullTime { get; set; }

        public bool KnowsCSharp { get; set; }

        public bool KnowsCplusPlus { get; set; }

        public bool KnowsJavaScript { get; set; }

        public string Role { get; set; }

        public DateTime StartDate { get; set; }
    }
}
