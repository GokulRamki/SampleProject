using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SampleProject.Models
{
    public class bm_slider_cms
    {
        [Key()]
        public long Id { get; set; }

        [Required()]
        public string Slider_name { get; set; }

        public string Slider_Img { get; set; }

        public string Redirect_url { get; set; }

        [Required()]
        [Display(Name = "Order Id")]
        public int Img_Order { get; set; }

        public bool Is_Active { get; set; }

        public bool Is_Deleted { get; set; }

        public Nullable<DateTime> Created_On { get; set; }

        public Nullable<DateTime> Modified_On { get; set; }
    }
}
