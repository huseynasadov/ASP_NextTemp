using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class BlogListVM
    {
        public _SidebarVM _SidebarVM { get; set; }
        public HeaderSetting HeaderSetting { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}