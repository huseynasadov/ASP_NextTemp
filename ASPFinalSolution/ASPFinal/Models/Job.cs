using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public enum Gender {All,Male,Female}
    public enum Shift{ Morning, Evening }
    public enum JobExpYear {One,Two,Three}
    public enum JobType {Fulltime,Parttime }
    public class Job
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string CompanyName { get; set; }
        [Required,MaxLength(550)]
        public string Title { get; set; }
        [Required, MaxLength(100)]
        public string Slug { get; set; }
        public JobCategory Category { get; set; }
        public JobEduLevel JobEduLevel { get; set; }
        public int CategoryId { get; set; }
        public int JobEduLevellId { get; set; }
        public JobExpYear JobExpYear { get; set; }
        public JobType JobType { get; set; }
        public Gender Gender { get; set; }
        public Shift Shift { get; set; }
        [Required, MaxLength(80)]
        public string Address { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }
        [MaxLength(200)]
        public string WebSite { get; set; }
        [Required,EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,MaxLength(13),MinLength(10)]
        public string Phone { get; set; }
        [Required,Column(TypeName ="ntext")]
        public string Desc { get; set; }
        public ICollection<Qualification> Qualifications { get; set; }
        public ICollection<Responsibility> Responsibilities { get; set; }
        public ICollection<OpeningHour> OpeningHours { get; set; }
        [MaxLength(250)]
        public string Photo { get; set; }
        [NotMapped,Display(Name ="Photo Upload")]
        public HttpPostedFileBase PhotoUpload { get; set; }
        [Display(Name ="Create At"),DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        public string Hours { get; set; }
        public bool Status { get; set; }
    }
}