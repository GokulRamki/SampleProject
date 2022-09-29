using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SampleProject.Models
{
    public class adminmodel
    {
        [Required()]
        [Display(Name = "Username")]
        public string username { get; set; }
        [Required()]
        [Display(Name = "Password")]
        public string password { get; set; }
    }
}