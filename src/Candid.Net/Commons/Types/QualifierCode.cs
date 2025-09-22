using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

[JsonConverter(typeof(EnumSerializer<QualifierCode>))]
public enum QualifierCode
{
    [EnumMember(Value = "DQ")]
    Dq,

    [EnumMember(Value = "DN")]
    Dn,

    [EnumMember(Value = "DK")]
    Dk,

    [EnumMember(Value = "P3")]
    P3,
}
