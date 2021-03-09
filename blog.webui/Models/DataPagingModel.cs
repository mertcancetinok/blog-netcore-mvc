using blog.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Models
{
    public class DataPagingModel<T> where T:class
    {
        public PageModel PageModel { get; set; }
        public List<T> Data { get; set; }
    }
}
