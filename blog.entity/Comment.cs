﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.entity
{
    public class Comment
    {
        public string Id { get; set; }
        public string Writer { get; set; }
        public string Content { get; set; }
        public DateTime AddedTime { get; set; }
        public bool IsApproved { get; set; }
        public Blog Blog { get; set; }        
    }
}
