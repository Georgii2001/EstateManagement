﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateManagement.Models
{
    public class Owner
    {
        public int Id { get; set; } //cheia primara din tabel
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cnp { get; set; }
        public static List<Estate> Estates { get; set; }

        public Owner()
        {
            Estates = new List<Estate>();
        }
    }
}
