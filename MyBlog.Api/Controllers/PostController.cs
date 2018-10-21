using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Core.Interfaces;
using MyBlog.Infrastructure.DataBase;
using MyBlog.Infrastructure.Repositories;
using MyBlog.Infrastructure.Resources;

namespace MyBlog.Api.Controllers
{
    [Route("api/posts")]
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public PostController(IPostRepository postRepository,IUnitOfWork unitOfWork
            ,IMapper mapper)
        {
            _postRepository = postRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var posts =  _postRepository.GetAllPostsAsync();为什么不支持
            var posts = await _postRepository.GetAllPostsAsync();
            var postResources = _mapper.Map <IEnumerable< Post >, IEnumerable< PostResource>> (posts);
            return Ok(postResources);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var post = await _postRepository.GetAllPostByIdAsync(id);
            if (post == null)
                return NotFound();
            var postResource= _mapper.Map<Post, PostResource>(post);
            return Ok(postResource);
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var post = new Post
            {
                Author = "Author3",
                Body = "Body3",
                LastModified = DateTime.Now,
                Title="Title3"
            };
            _postRepository.AddPost(post);
            await _unitOfWork.SaveAsync();
            return Ok();
        }
    }
}