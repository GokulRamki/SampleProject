using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SampleProject.Models
{
    public class web_tbl_care_user
    {
        [Key]
        public long id { get; set; }

        [Required]
        public int role_id { get; set; }

        [Required]
        [Remote("UserExists", "Admin", AdditionalFields = "user_name,role_id", ErrorMessage = "Username already exists!")]
        public string user_name { get; set; }

        [Required]
        public string user_pwd { get; set; }

        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set; }

        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        public string email_id { get; set; }

        [Required]
        public string contact_number { get; set; }

        public bool is_active { get; set; }

        public bool is_deleted { get; set; }

        public Nullable<DateTime> creadted_on { get; set; }

        public Nullable<DateTime> modified_on { get; set; }

    }
}
