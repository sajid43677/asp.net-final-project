﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SecSecurityDTO
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }
        [Required]
        public string phone { get; set; }
        [Required]
        public string password { get; set; }
    }
}
