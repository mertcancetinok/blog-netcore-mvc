using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.entity
{
    public class BlogCategory
    {
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public int CategoryId{ get; set; }
        public Category Category { get; set; }
    }
}
