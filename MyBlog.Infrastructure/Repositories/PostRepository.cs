using MyBlog.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using System.Threading.Tasks;
using MyBlog.Core.Interfaces;

namespace MyBlog.Infrastructure.Repositories
{
    public class PostRepository:IPostRepository
    {
        private readonly MyContext _myContext;
        public PostRepository(MyContext myContext)
        {
            _myContext = myContext;
        }
        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return await _myContext.Posts.ToListAsync();

        }
        public async Task<Post> GetAllPostByIdAsync(int id)
        {
            return await _myContext.Posts.FindAsync(id);

        }

        public void AddPost(Post post)
        {
            _myContext.Posts.Add(post);
        }

        
    }
}
