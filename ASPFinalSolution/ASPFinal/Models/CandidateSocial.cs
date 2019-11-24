using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class CandidateSocial
    {
        public int Id { get; set; }
        public SocialLink SocialLink { get; set; }
        public int SocialLinkId { get; set; }
        public Candidate Candidate { get; set; }
        public int CandidateId { get; set; }

        public string Link { get; set; }
    }
}