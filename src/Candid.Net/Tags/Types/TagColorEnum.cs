using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(EnumSerializer<TagColorEnum>))]
public enum TagColorEnum
{
    [EnumMember(Value = "black")]
    Black,

    [EnumMember(Value = "white")]
    White,

    [EnumMember(Value = "gray")]
    Gray,

    [EnumMember(Value = "red")]
    Red,

    [EnumMember(Value = "yellow")]
    Yellow,

    [EnumMember(Value = "green")]
    Green,

    [EnumMember(Value = "blue")]
    Blue,

    [EnumMember(Value = "indigo")]
    Indigo,

    [EnumMember(Value = "purple")]
    Purple,

    [EnumMember(Value = "pink")]
    Pink,
}
