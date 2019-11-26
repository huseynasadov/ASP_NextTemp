using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class FaqVM
    {
        public HeaderSetting HeaderSetting { get; set; }
        public Breadcrumb breadcrumb { get; set; }
        public ICollection<Faq> Faqs{ get; set; }
    }
}