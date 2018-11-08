using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLayoutTest
{
    public class Resume
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	    public int Id { get; set; }
	    public string Name { get; set; }
	    public bool FullTime { get; set; }
	    public bool KnowsCSharp { get; set; }
	    public bool KnowsCPlusPlus { get; set; }
	    public bool KnowsJavaScript { get; set; }
	    public string Role { get; set; }
	    public DateTime StartDate { get; set; }
    }
}
