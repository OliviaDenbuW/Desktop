using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLayoutTest
{
    public class MyDbContext: DbContext
    {
	    public DbSet<Resume> Resumes { get; set; }
    }
}
