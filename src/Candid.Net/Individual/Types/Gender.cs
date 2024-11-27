using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(EnumSerializer<Gender>))]
public enum Gender
{
    [EnumMember(Value = "male")]
    Male,

    [EnumMember(Value = "female")]
    Female,

    [EnumMember(Value = "other")]
    Other,

    [EnumMember(Value = "not_given")]
    NotGiven,

    [EnumMember(Value = "unknown")]
    Unknown,
}
