using Microsoft.AspNetCore.Mvc.Rendering;
using omtentaASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace omtentaASPNET.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            FavoritÅrstider = new List<SelectListItem>();
            FavoritGodisar = new List<Godis>();
        }

        public User MinPerson { get; set; }

        public List<SelectListItem> FavoritÅrstider { get; set; }

        public List<Godis> FavoritGodisar { get; set; }
    }
}
