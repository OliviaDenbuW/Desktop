using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OliviaDemoASPNETRepetitionMVC.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public int PersonType { get; set; }
    }
}
