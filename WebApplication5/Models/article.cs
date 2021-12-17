using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class article
    {
        [Key]
        public int id { get; set; }

        [MaxLength(250)]
        public int title { get; set; }
        [MaxLength(250)]
        public string image { get; set; }
        public string content { get; set; }
        public int views { get; set; }
        public int like { get; set; }
        public int dislike { get; set; }
    
        public DateTime date { get; set; }

    }

}
