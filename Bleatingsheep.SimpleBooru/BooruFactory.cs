using System;
using WebApiClient;

namespace Bleatingsheep.SimpleBooru
{
    public static class BooruFactory
    {
        private static readonly Lazy<IBooruClient> s_konachanLazy;
        private static readonly Lazy<IBooruClient> s_yandereLazy;

        static BooruFactory()
        {
            s_konachanLazy = new Lazy<IBooruClient>(() => CreateClient("https://konachan.com"));
            s_yandereLazy = new Lazy<IBooruClient>(() => CreateClient("https://yande.re"));
        }

        public static IBooruClient CreateClient(string host)
        {
            var config = new HttpApiConfig
            {
                HttpHost = new Uri(host),
            };
            var bApi = HttpApi.Create<IBooruClient>(config);
            return bApi;
        }

        public static IBooruClient Konachan => s_konachanLazy.Value;

        public static IBooruClient Yandere => s_yandereLazy.Value;
    }
}
