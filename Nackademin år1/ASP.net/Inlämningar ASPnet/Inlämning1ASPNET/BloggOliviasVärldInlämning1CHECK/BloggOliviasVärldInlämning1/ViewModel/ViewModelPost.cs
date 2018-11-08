using BloggOliviasVärldInlämning1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggOliviasVärldInlämning1.ViewModel
{
    public class ViewModelPost
    {
        public Posts CurrentPost { get; set; }

        public List<SelectListItem> Categories { get; set; }
    }
}
