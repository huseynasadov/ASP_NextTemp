using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class EmployerListVM
    {
        public HeaderSetting HeaderSetting { get; set; }
        public _SidebarVM _SidebarVM { get; set; }
        public ICollection<Employer> Employers { get; set; }
        public PaginationVM Pagination { get; set; }
    }
}