using System.Threading;
using WebApiClient;
using WebApiClient.Attributes;

namespace Bleatingsheep.SimpleBooru
{
    public interface IBooruClient : IHttpApi
    {
        [HttpGet("post/popular_recent.json")]
        [JsonReturn]
        ITask<Post[]> GetPopularRecentAsync(CancellationToken cancellationToken = default);

        [HttpGet("post.json")]
        [JsonReturn]
        ITask<Post[]> GetRecentAsync(CancellationToken cancellationToken = default);

        [HttpGet("post.json")]
        [JsonReturn]
        ITask<Post[]> GetPostsAsync(string tags, CancellationToken cancellationToken = default);

        [HttpGet("post.json")]
        [JsonReturn]
        ITask<Post[]> GetPostsAsync(string tags, int limit, int page, CancellationToken cancellationToken = default);
    }
}
