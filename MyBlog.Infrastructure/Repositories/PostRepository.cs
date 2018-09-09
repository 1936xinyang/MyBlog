using MyBlog.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using System.Threading.Tasks;
using MyBlog.Core.interfaces;

namespace MyBlog.Infrastructure.Repositories
{
    public class PostRepository:IPostRepository
    {
        private readonly MyContext _myContext;
        public PostRepository(MyContext myContext)
        {
            _myContext = myContext;
        }
        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return await _myContext.Posts.ToListAsync();

        }
    }
}
