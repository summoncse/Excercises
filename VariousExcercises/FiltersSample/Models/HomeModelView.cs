﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersSample.Models
{
    public class HomeModelView
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
