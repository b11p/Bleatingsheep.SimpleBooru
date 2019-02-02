using System.Runtime.Serialization;

namespace Bleatingsheep.SimpleBooru
{
    public enum Rating
    {
        [EnumMember(Value = "s")]
        Safe,
        [EnumMember(Value = "q")]
        Questionable,
        [EnumMember(Value = "e")]
        Explicit,
    };
}