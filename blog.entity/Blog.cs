using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.entity
{
    public class Blog
    {
        public int Id { get; set; }
        public int ClickCount { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public int ReadTime { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? AddedTime { get; set; }
        public Blogger Blogger { get; set; }
        public int BloggerId { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
