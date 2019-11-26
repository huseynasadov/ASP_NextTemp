using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class BlogDetailVM
    {
        public _SidebarVM _Sidebar { get; set; }
        public Blog Blog { get; set; }
        public HeaderSetting HeaderSetting { get; set; }
    }
}