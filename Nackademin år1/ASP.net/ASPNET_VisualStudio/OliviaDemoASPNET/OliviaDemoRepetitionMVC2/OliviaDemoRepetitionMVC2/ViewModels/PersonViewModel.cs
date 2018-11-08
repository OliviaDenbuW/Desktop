using Microsoft.AspNetCore.Mvc.Rendering;
using OliviaDemoRepetitionMVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OliviaDemoRepetitionMVC2.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            PersonTyper = new List<SelectListItem>();
        }

        public Person MinPerson { get; set; }
        public List<SelectListItem> PersonTyper { get; set; }
    }
}
