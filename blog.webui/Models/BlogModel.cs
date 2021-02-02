using blog.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Models
{
    public class BlogModel
    {
        

        public int BlogId { get; set; }
        
        public int BloggerId { get; set; }
        [Required]
        public string BlogName { get; set; }
        public DateTime? BlogDate { get; set; }
        [Required]
        public string BlogContent { get; set; }
        [Required]
        public int? BlogReadTime { get; set; }

        public Blogger Blogger { get; set; }

        

    }
}
