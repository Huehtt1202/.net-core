﻿using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class User 
    {
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();
        public string? UserName { get; set; }
        public string? DisplayUserName { get; set; }
        public string? Password { get; set; }
    }
}
