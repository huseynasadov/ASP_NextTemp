using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public enum MartialStatus {
        Single,
        Married
    }
    public class Candidate
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Firstname { get; set; }
        [MaxLength(50)]
        public string Lastname { get; set; }
        [EmailAddress,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Slug { get; set; }
        [DataType(DataType.Date),Column(TypeName ="date")]
        public DateTime BirthDate { get; set; }
        [MaxLength(250)]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        [Column(TypeName ="ntext")]
        public string AboutMe { get; set; }
        [Column(TypeName = "ntext")]
        public string Overview { get; set; }
        [MaxLength(100)]
        public string Profession { get; set; }

        public ICollection<CandidateSocial> CandidateSocials { get; set; }

        public ICollection<Education> Educations { get; set; }
        public ICollection<Experience> Experiences { get; set; }
        public ICollection<Skill> Skils { get; set; }
        public Gender Gender { get; set; }
        public MartialStatus MartialStatus { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        public string Phone { get; set; }
        [MaxLength(100)]
        public string Website { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        public string Amount { get; set; }
        public bool Status { get; set; }
        public User User { get; set; }
        public int? UserId { get; set; }

    }
}