﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTomasos.Models
{
    public class DishModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Type { get; set; }

        public string Products { get; set; }
    }
}
