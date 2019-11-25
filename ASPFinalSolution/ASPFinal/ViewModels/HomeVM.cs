using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class HomeVM
    {
        public Setting Setting { get; set; }
        public HeaderSetting HeaderSetting { get; set; }
        public ICollection<Job> Jobs { get; set; }
        public ICollection<HowItWork> HowItWorks { get; set; }
        public ICollection<Employer> Employers { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
        public int BlogCounts { get; set; }
        public ICollection<Partner> Partners { get; set; }
    }
}