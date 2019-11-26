using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class ContactVM
    {
        public Setting Setting { get; set; }
        public Breadcrumb breadcrumb { get; set; }
        public HeaderSetting HeaderSetting { get; set; }
    }
}