using Microsoft.AspNetCore.Mvc.Rendering;
using OliviaDemoASPNETRepetitionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OliviaDemoASPNETRepetitionMVC.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            PersonTypes = new List<SelectListItem>();
        }

        public Person CurrentPerson { get; set; }
        public List<SelectListItem> PersonTypes { get; set; }
    }
}
