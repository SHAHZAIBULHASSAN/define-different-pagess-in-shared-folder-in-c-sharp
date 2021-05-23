using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace shahpractice.Models
{
    public class Employee
    {
      

        public int Id { get; set; }
        [Display(Name="please enter id")]
        [Validation]
        public string Name { get; set; }
        [Required(ErrorMessage="sss")]
        public string Lastname { get; set; }
             
        public DateTime dateTime { get; set; }
        [Required(ErrorMessage ="YES")]
        public string Email { get; set; }
        public bool Idonline { get; set; }
        }
    }
