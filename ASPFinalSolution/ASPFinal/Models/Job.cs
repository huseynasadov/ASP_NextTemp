using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public enum Gender { Male,Female}
    public enum Shift{ Morning, Evening }
    public enum JobExpYear {One,Two,Three}
    public enum JobCountry { Afghanistan, Bangladesh, Canada , Dominica }
    public class Job
    {
        public int Id { get; set; }
        [Required,MaxLength(150)]
        public string Title { get; set; }
        public JobCategory Category { get; set; }
        public JobEduLevel JobEduLevel { get; set; }
        public int CountryId { get; set; }
        public int JobEduLevellId { get; set; }
        public JobCountry Country { get; set; }
        public JobExpYear JobExpYear { get; set; }
        [Required,MaxLength(80)]
        public string City { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }
        [MaxLength(200)]
        public string WebSiteLink { get; set; }
        [Required,EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,MaxLength(13),MinLength(10)]
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public Shift Shift { get; set; }
        [Required,Column(TypeName ="ntext")]
        public string Desc { get; set; }
        [MaxLength(250)]
        public string Photo { get; set; }
        [NotMapped,Display(Name ="Photo Upload")]
        public HttpPostedFileBase PhotoUpload { get; set; }
        [Display(Name ="Create At"),DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }
    }
}