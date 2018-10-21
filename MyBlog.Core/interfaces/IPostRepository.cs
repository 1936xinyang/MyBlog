using MyBlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Core.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetAllPostsAsync();

        Task<Post> GetAllPostByIdAsync(int id);
        void AddPost(Post post);
    }
}
