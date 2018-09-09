using MyBlog.Core.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Core.Entities
{
    public abstract class Entity:IEntity
    {
        public int Id { get; set; }
    }
}
