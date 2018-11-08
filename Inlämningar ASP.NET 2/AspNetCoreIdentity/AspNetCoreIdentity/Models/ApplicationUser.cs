using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AspNetCoreIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        //Possible to extend; Ex Region
    }
}
