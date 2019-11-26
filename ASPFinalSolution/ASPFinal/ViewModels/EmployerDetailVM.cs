using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class EmployerDetailVM
    {
        public Breadcrumb Breadcrumb { get; set; }
        public  Employer Employer { get; set; }
        public HeaderSetting HeaderSetting { get; set; }
    }
}