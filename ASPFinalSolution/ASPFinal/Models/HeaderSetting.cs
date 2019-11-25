using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public enum Page {
        Home,
        JobGrid,
        JobDetail,
        JobPost,
        CandidateList,
        CandidateDetail,
        CandidateResume,
        EmployerList,
        EmlpoyerDetail,
        BlogList,
        BlogDetail,
        AboutUs,
        Service,
        Team,
        Faq,
        Pricing,
        Contact
    }
    public class HeaderSetting
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string  Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase  PhotoUpload { get; set; }
        public Page Page { get; set; }
    }
}