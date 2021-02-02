using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IconClass { get; set; }
        public List<BlogCategory> BlogCategories{ get; set; }
    }
}
