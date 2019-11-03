using AutoMapper;
using MyBlog.Core.Entities;
using MyBlog.Infrastructure.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Api.Extensions
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Post, PostResource>().ForMember(dest=> dest.UpdateTime,opt=>opt.MapFrom(src=>src.LastModified));
            CreateMap<PostResource,Post> ();
        }
    }
}
