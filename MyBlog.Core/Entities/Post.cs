using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Core.Entities
{
    public class Post:Entity
    {
        protected new int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime LastModified { get; set; }
    }
}
