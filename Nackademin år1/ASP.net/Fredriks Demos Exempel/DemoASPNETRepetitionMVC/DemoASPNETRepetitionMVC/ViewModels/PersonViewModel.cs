using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoASPNETRepetitionMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoASPNETRepetitionMVC.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            Categories = new List<SelectListItem>();
        }

        public Person MyPerson { get; set; }
        public List<SelectListItem> Categories { get; set; }

    }
}
