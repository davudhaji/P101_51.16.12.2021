using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class category
    {
        [Key]
        public int id { get; set; }
        [MaxLength(150)]
        public string name { get; set; }

        List<article> articles;
        
    }
}
