using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lesson5.Models
{
     public class plans
     {
        [Required]
        [Key]
        public int id{get;set;}

        public string planName{get;set;}

        public int planPrice{get;set;}

        public int planLimit{get;set;}

        public DateTime date{get;set;}
     }
}