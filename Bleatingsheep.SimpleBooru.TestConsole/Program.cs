using System;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebApiClient;

namespace Bleatingsheep.SimpleBooru.TestConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var kApi = BooruFactory.Yandere;
            var popular = await kApi.GetPostsAsync("id:513752", 100, 1);
            var groups = popular.GroupBy(p => p.Status);
            var nullCreator = popular.Where(p => p.CreatorId == null);
            var newJson = JsonConvert.SerializeObject(popular);
        }
    }
}
