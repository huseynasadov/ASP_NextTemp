 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class Employer
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Firstname { get; set; }
        [MaxLength(50)]
        public string Lastname { get; set; }
        public ICollection<EmployerCategory> EmployerCategory { get; set; }
        [MaxLength(100)]
        public string Slug { get; set; }
        [MaxLength(150)]
        public string Address { get; set; }
        [Range(0,5)]
        public int? Rate { get; set; }
        [MaxLength(250)]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public bool isVerified { get; set; }
        [MaxLength(150)]
        public string CompanyName { get; set; }
        [MaxLength(150)]
        public string CompanyAdress { get; set; }
        [MaxLength(150)]
        public string CompanyPhone { get; set; }
        [MaxLength(150)]
        public string CompanyWebsite { get; set; }
        [EmailAddress]
        public string CompanyEmail { get; set; }
        public int? Empl0yers { get; set; }
        public string Type { get; set; }
        public string ExperienceDate { get; set; }
        public int? minSalary { get; set; }
        public int? maxSalary { get; set; }
        public int? Followers { get; set; }
        [Column(TypeName ="ntext")]
        public string Overview { get; set; }
        [Column(TypeName = "ntext")]
        public string Services { get; set; } 
        public ICollection<EmployerReview> EmployerReviews { get; set; }
        public DateTime? CreatedAt { get; set; }
        public ICollection<CompanyPhoto> CompanyPhotos { get; set; }
        public bool Status { get; set; }
        public User User { get; set; }
        public int? UserId { get; set; }
    }
}