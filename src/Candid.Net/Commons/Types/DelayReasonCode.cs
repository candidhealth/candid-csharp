using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<DelayReasonCode>))]
public enum DelayReasonCode
{
    [EnumMember(Value = "1")]
    C1,

    [EnumMember(Value = "2")]
    C2,

    [EnumMember(Value = "3")]
    C3,

    [EnumMember(Value = "4")]
    C4,

    [EnumMember(Value = "5")]
    C5,

    [EnumMember(Value = "6")]
    C6,

    [EnumMember(Value = "7")]
    C7,

    [EnumMember(Value = "8")]
    C8,

    [EnumMember(Value = "9")]
    C9,

    [EnumMember(Value = "10")]
    C10,

    [EnumMember(Value = "11")]
    C11,

    [EnumMember(Value = "15")]
    C15,

    [EnumMember(Value = "16")]
    C16,

    [EnumMember(Value = "17")]
    C17,
}
