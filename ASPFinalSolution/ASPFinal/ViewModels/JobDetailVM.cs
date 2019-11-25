using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class JobDetailVM
    {
        public Breadcrumb Breadcrumb { get; set; }
        public Job Job { get; set; }
        public HeaderSetting HeaderSetting { get; set; }
    }
}