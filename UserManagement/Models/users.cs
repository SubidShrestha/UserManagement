using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UserManagement.Models
{
    public enum gender
    {
        Male, Female,Other
    }
    public class users
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="First Name is required"),Display(Name = "First Name"),MaxLength(26)]
        public string firstname { get; set; }
        [Required(ErrorMessage ="Last Name is required"),Display(Name = "Last Name"),MaxLength(26)]
        public string lastname { get; set; }
        [Required(ErrorMessage ="Email is required"),Display(Name = "Email"),EmailAddress]
        public string email { get; set; }
        [Display(Name ="Phone")]
        public string phone { get; set; }
        [Display(Name = "Gender")]
        public gender Gender { get; set; }

    }

}