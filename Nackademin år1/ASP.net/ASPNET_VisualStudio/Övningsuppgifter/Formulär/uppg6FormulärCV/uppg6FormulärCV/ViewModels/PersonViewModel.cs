using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uppg6FormulärCV.Models;

namespace uppg6FormulärCV.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            UtbildningsBeskrivningar = new List<SelectListItem>();
            Regioner = new List<Region>();
            Körkortsstatusar = new List<Körkortsstatus>();
        }

        public Person MinPerson { get; set; }

        //Dropdown list
        public List<SelectListItem> UtbildningsBeskrivningar { get; set; }

        //Listbox
        public List<SelectListItem> Hobbisar { get; set; }

        //Radio button
        public List<Region> Regioner { get; set; }

        //Checkbox
        public List<Körkortsstatus> Körkortsstatusar { get; set; }        
    }
}
