using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class PricingVM
    {
        public HeaderSetting HeaderSetting { get; set; }
        public Breadcrumb breadcrumb { get; set; }
        public ICollection<Pricing> Pricing { get; set; }
    }
}