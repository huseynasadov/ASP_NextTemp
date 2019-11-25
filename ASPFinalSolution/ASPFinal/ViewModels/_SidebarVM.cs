using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class _SidebarVM
    {
        public Breadcrumb Breadcrumb { get; set; }
        public ICollection<JobCategory> JobCategories { get; set; }
        public ICollection<string> Professions { get; set; }
        public ICollection<Skill> Skills { get; set; }
    }
}