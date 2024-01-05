using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lesson5.Models
{
     public class posts
     {
        [Key]
        public int Id { get; set; }
       
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public int documentPrice{get;set;}
        public int off{get;set;}
        [NotMapped]
        public IFormFile Image { get; set; }
     }
}