namespace Bleatingsheep.SimpleBooru
{
    using System;
    using System.ComponentModel;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class Post
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("creator_id")]
        public int? CreatorId { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("change")]
        public long Change { get; set; }

        /// <summary>
        /// Can not be assumed as a URI. For example, yande.re post ID 462883.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("file_url")]
        public Uri FileUrl { get; set; }

        [JsonProperty("is_shown_in_index")]
        public bool IsShownInIndex { get; set; }

        [JsonProperty("preview_url")]
        public Uri PreviewUrl { get; set; }

        [JsonProperty("preview_width")]
        public int PreviewWidth { get; set; }

        [JsonProperty("preview_height")]
        public int PreviewHeight { get; set; }

        [JsonProperty("actual_preview_width")]
        public int ActualPreviewWidth { get; set; }

        [JsonProperty("actual_preview_height")]
        public int ActualPreviewHeight { get; set; }

        [JsonProperty("sample_url")]
        public Uri SampleUrl { get; set; }

        [JsonProperty("sample_width")]
        public int SampleWidth { get; set; }

        [JsonProperty("sample_height")]
        public int SampleHeight { get; set; }

        [JsonProperty("sample_file_size")]
        public int SampleFileSize { get; set; }

        [JsonProperty("jpeg_url")]
        public Uri JpegUrl { get; set; }

        [JsonProperty("jpeg_width")]
        public int JpegWidth { get; set; }

        [JsonProperty("jpeg_height")]
        public int JpegHeight { get; set; }

        [JsonProperty("jpeg_file_size")]
        public int JpegFileSize { get; set; }

        [JsonProperty("rating")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Rating Rating { get; set; }

        [JsonProperty("has_children")]
        public bool HasChildren { get; set; }

        [JsonProperty("parent_id")]
        public int? ParentId { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Status Status { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("is_held")]
        public bool IsHeld { get; set; }

        [JsonProperty("frames_pending_string")]
        public string FramesPendingString { get; set; }

        [JsonProperty("frames_pending")]
        public object[] FramesPending { get; set; }

        [JsonProperty("frames_string")]
        public string FramesString { get; set; }

        [JsonProperty("frames")]
        public object[] Frames { get; set; }

        [JsonProperty("flag_detail")]
        public FlagDetail FlagDetail { get; set; }

        /// <summary>
        /// Not supported in some websites like Konachan.
        /// </summary>
        [JsonProperty("updated_at", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [DefaultValue(0)]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("approver_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApproverId { get; set; }

        [JsonProperty("file_ext", NullValueHandling = NullValueHandling.Ignore)]
        public string FileExt { get; set; }

        [JsonProperty("is_rating_locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRatingLocked { get; set; }

        [JsonProperty("is_pending", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPending { get; set; }

        [JsonProperty("is_note_locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNoteLocked { get; set; }

        [JsonProperty("last_noted_at", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        [DefaultValue(0)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset? LastNotedAt { get; set; }

        [JsonProperty("last_commented_at", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        [DefaultValue(0)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset? LastCommentedAt { get; set; }

        public override string ToString() => $"{Id} {Tags}";
    }
}