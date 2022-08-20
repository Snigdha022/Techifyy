﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechifyyNew.Models
{
    public class loginUser
    {
        [Required]
        [Display(Name = " Enter Email Address")]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }


        [Required]
        [Display(Name = "Enter Password")]
        [DataType(DataType.Password)]
        [Compare("UserPassword", ErrorMessage = "Password Not Matched")]
        public string UserPassword { get; set; }

        public string ConString = @"data source=AsifHridoy;initial catalog=techifyy;integrated security=True;pooling=False;MultipleActiveResultSets=True;App=EntityFramework&quot;";

    }
}