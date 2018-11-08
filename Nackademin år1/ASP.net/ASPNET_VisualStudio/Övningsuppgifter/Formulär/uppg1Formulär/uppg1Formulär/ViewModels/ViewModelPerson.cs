using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uppg1Formulär.Models;

namespace uppg1Formulär.ViewModels
{
    public class ViewModelPerson
    {
        public ViewModelPerson()
        {
            Countries = new List<SelectListItem>();
        }

        public User CurrentPerson { get; set; }

        public List<SelectListItem> Countries { get; set; }
        public List<SelectListItem> UserTypes { get; set; }
    }
}
