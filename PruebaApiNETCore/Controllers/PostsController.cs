using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaApiNETCore.DTOs;
using PruebaApiNETCore.Services;

namespace PruebaApiNETCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostsService _postsService;

        public PostsController(IPostsService postsService)
        {
            _postsService = postsService;
        }

        [HttpGet]
        public async Task<IEnumerable<PostDto>> Get()
        {
            return await _postsService.Get();
        }
    }
}
