using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class CandidateDetailVM
    {
        public Candidate Candidate { get; set; }
        public HeaderSetting HeaderSetting { get; set; }
    }
}