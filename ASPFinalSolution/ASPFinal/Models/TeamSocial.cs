using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class TeamSocial
    {
        public int Id { get; set; }
        public SocialLink Social { get; set; }
        public int SocialId { get; set; }
        public Team Team { get; set; }
        public int TeamId { get; set; }
        public string Link { get; set; }
    }
}