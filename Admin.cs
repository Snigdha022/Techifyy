//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechifyyNew.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Admin
    {
        public int AdminID { get; set; }
        [DisplayName("Admin Email")]
        [Required(ErrorMessage = "Field is required")]
        public string AdminEmail { get; set; }
        public string AdminName { get; set; }
        public string AdminImg { get; set; }
        [DisplayName("Admin Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Field is required")]
        public string AdminPassword { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}