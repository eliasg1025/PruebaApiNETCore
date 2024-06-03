using PruebaApiNETCore.DTOs;

namespace PruebaApiNETCore.Services
{
    public interface IPostsService
    {
        public Task<IEnumerable<PostDto>> Get();
    }
}
