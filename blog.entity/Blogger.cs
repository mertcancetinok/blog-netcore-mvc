using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.entity
{
    public class Blogger
    {
        public Blogger()
        {
            this.Blog = new List<Blog>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string JobTitle { get; set; }
        public List<Blog> Blog { get; set; }
    }
}
