using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class SettingSocial
    {

        public int Id { get; set; }
        public SocialLink SocialLink { get; set; }
        public int SocialLinkId { get; set; }
        public Setting Setting { get; set; }
        public int SettingId { get; set; }

        public string Link { get; set; }
    }
}