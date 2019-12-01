using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class JobListVM
    {
        public HeaderSetting HeaderSetting { get; set; }
        public _SidebarVM _SidebarVM { get; set; }
        public ICollection<Job> Jobs { get; set; }
        public PaginationVM Pagination { get; set; }
    }
}