using System;
using Newtonsoft.Json;

namespace Bleatingsheep.SimpleBooru
{
    public class FlagDetail
    {
        [JsonProperty("post_id")]
        public int PostId { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("flagged_by")]
        public string FlaggedBy { get; set; }
    }
}
