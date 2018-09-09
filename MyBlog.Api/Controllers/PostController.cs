using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlog.Infrastructure.DataBase;

namespace MyBlog.Api.Controllers
{
    [Route("api/posts")]
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly MyContext _myContext;
        public PostController(MyContext myContext)
        {
            _myContext = myContext;
        }
        public async Task<IActionResult> Get()
        {
            var posts = await _myContext.Posts.ToListAsync();
            return Ok(posts);
        }
    }
}