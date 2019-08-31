using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Core.Interfaces;
using MyBlog.Infrastructure.DataBase;
using MyBlog.Infrastructure.Extensions;
using MyBlog.Infrastructure.Resources;
using MyBlog.Infrastructure.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly MyContext _myContext;
        private readonly IPropertyMappingContainer _propertyMappingContainer;

        public PostRepository(MyContext myContext,
            IPropertyMappingContainer propertyMappingContainer)
        {
            _myContext = myContext;
            _propertyMappingContainer = propertyMappingContainer;
        }

        public async Task<PaginatedList<Post>> GetAllPostsAsync(PostParameters postParameters)
        {
            var query = _myContext.Posts.AsQueryable();

            if (!string.IsNullOrEmpty(postParameters.Title))
            {
                var title = postParameters.Title.ToLowerInvariant();
                query = query.Where(x => x.Title.ToLowerInvariant() == title);
            }

            query = query.ApplySort(postParameters.OrderBy, _propertyMappingContainer.Resolve<PostResource, Post>());

            var count = await query.CountAsync();
            var data = await query
                .Skip(postParameters.PageIndex * postParameters.PageSize)
                .Take(postParameters.PageSize)
                .ToListAsync();

            return new PaginatedList<Post>(postParameters.PageIndex, postParameters.PageSize, count, data);
        }

        public async Task<Post> GetPostByIdAsync(int id)
        {
            try
            {
                var tt = _myContext.Posts;
            }
            catch (Exception ex)
            {
            }
            
            return await _myContext.Posts.FindAsync(id);
        }

        public void AddPost(Post post)
        {
            _myContext.Posts.Add(post);
        }
    }
}
