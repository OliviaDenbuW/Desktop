using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uppg6Formulär.Models;

namespace uppg6Formulär.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            //Utbildningsbeskrivningar = new List<SelectListItem>();
            //Regioner = new List<Region>();
        }

        public Person MinPerson { get; set; }
        
        public List<SelectListItem> Utbildningsbeskrivningar { get; set; }
        public List<Region> Regioner { get; set; }
        public List<Körkort> KörkortStatusar { get; set; }
     }
}
