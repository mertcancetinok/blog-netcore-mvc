using blog.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Models
{
    public class HomeModel
    {
        public List<Blog> Popular { get; set; }
        public List<Blog> GetAll { get; set; }
        public PageModel PageModel { get; set; }
    }
}
