using Microsoft.AspNetCore.Mvc.Rendering;
using omtentaASPNET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace omtentaASPNET.ViewModels
{
    public class ProduktViewModel
    {
        public Products MinProdukt { get; set; }

        public List<SelectListItem> Produkter { get; set; }

        public int[] ProduktIdn { get; set; }

        [Range(0, 4, ErrorMessage = "Maxantal är 4 st")]
        public int Antal { get; set; }
    }
}
