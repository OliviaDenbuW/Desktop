﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uppg1WebApiOchJSON.Models
{
    public class Person
    {
        public Person(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public string Name { get; set; }
        public string Email { get; set; }
    }
}
