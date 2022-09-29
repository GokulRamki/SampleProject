using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SampleProject.Models
{
    public class sampleproject_DBEntities : DbContext
    {
        public sampleproject_DBEntities() : base("sampleproject_DBEntities") { }

        public DbSet<bm_slider_cms> bm_slider { get; set; }

        public DbSet<web_tbl_care_user> care_users { get; set; }

        public DbSet<adminmodel> adminmodel { get; set; }
    }
}