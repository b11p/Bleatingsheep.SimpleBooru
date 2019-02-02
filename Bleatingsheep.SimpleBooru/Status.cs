using System.Runtime.Serialization;

namespace Bleatingsheep.SimpleBooru
{
    public enum Status
    {
        [EnumMember(Value = "active")]
        Active,
        /// <summary>
        /// This post is pending moderator approval.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>
        /// This post was flagged for deletion.
        /// </summary>
        [EnumMember(Value = "flagged")]
        Flagged,
    };
}