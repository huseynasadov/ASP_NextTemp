using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Firstname { get; set; }
        [Required, MaxLength(50)]
        public string Lastname { get; set; }
        [MaxLength(100)]
        public string Slug { get; set; }
        [MaxLength(250)]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public JobCategory Category { get; set; }
        public int CategoryId { get; set; }
        [Required,MaxLength(50)]
        public string ShortInfo { get; set; }
        public ICollection<TeamSocial> TeamSocials { get; set; }
        public int? OrderBy { get; set; }
        public bool Status { get; set; }
    }
}