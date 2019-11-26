using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [Required,MaxLength(50), Display(Name = "Logo Name")]
        public string LogoName { get; set; }
        [MaxLength(200)]
        public string Logo { get; set; }
        [NotMapped]
        [Display(Name ="Logo Upload")]
        public HttpPostedFileBase LogoUpload { get; set; }
        [Required, MaxLength(500)]
        public string Adress { get; set; }
        [Required, MaxLength(200),EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [MaxLength(14)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Website { get; set; }
        [Required, Column(TypeName ="ntext")]
        [Display(Name = "Description")]
        public string Desc { get; set; }
        [MaxLength(50)]
        public string HomeTitle { get; set; }
        public List<SettingSocial> SettingSocials { get; set; }
    }
}