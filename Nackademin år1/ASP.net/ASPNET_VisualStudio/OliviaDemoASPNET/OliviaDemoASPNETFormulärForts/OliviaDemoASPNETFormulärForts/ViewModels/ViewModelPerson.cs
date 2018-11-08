using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OliviaDemoASPNETFormulärForts.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OliviaDemoASPNETFormulärForts.ViewModels
{
    public class ViewModelPerson
    {
        
        public ViewModelPerson()
        {
            this.Countries = new List<Country>();
            this.PersonTypes = new List<SelectListItem>();
        }

        //ska innehålla ett personObjekt
        public Person CurrentPerson { get; set; }

        //Används för att skicka data till vyn
        public List<Country> Countries { get; set; }

        //Till vyn vill vi skicka en lista, med selectListItems (eftesom vi ska ha en dropdownLista), måste 
        //ha properties som hanterar det

        //Används för att skicka data till vyn
        public List<SelectListItem> PersonTypes { get; set; } 
    }
}
