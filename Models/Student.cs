using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace shahpractice.Models
{
    public class Student 
    {
        
        public int Id { get; set; }
        [Display(Name = "please enter id")]
        [Required]
        [Validation]
        public string Name { get; set; }
        [Required]
        public string Lastname { get; set; }

        public DateTime dateTime { get; set; }
        public string Email { get; set; }
        public Address add { get; set; }
    }
}