using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class CandidateListVM
    {
        public _SidebarVM _SidebarVM { get; set; }
        public HeaderSetting HeaderSetting { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<Skill> Skills { get; set; }
    }
}