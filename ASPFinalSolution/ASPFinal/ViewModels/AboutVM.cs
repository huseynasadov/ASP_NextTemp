using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class AboutVM
    {
        public HeaderSetting HeaderSetting { get; set; }
        public Breadcrumb breadcrumb { get; set; }
        public ICollection<AboutUs> Abouts { get; set; }
        public ICollection<Job> Jobs { get; set; }
        public ICollection<Partner> Partners { get; set; }
        public Employer Employer{ get; set; }
    }
}