using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoASPNETFormulärForts.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoASPNETFormulärForts.ViewModels
{
    
    public class ViewModelPerson
    {
        public ViewModelPerson()
        {
            Countries = new List<Country>();
            PersonTypes = new List<SelectListItem>();
        }

        //Används för model binding till formuläret
        public Person CurrentPerson { get; set; }

        //Används för att skicka data till vyn
        public List<Country> Countries { get; set; }
        
        //Används för att skicka data till vyn
        public List<SelectListItem> PersonTypes { get; set; }

    }
}
