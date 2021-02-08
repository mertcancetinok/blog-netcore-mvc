using blog.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Models
{
    public class BlogCategoriesViewModel
    {
        public Blog Blog { get; set; }
        public List<Category> Categories { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
