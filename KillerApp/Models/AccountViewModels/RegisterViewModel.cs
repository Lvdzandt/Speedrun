﻿using KillerApp.Objects;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Models
{
    public class RegisterViewModel
    {
        public User user { get; set; }

    }
}
