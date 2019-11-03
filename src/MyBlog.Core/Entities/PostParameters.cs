using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Core.Entities
{
    public class PostParameters : QueryParameters
    {
        public string Title { get; set; }
    }
}
