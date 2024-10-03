using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<ServiceAuthorizationExceptionCode>))]
public enum ServiceAuthorizationExceptionCode
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
}
