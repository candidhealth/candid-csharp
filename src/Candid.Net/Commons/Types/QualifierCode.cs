using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<QualifierCode>))]
public enum QualifierCode
{
    [EnumMember(Value = "DQ")]
    Dq,

    [EnumMember(Value = "DN")]
    Dn,

    [EnumMember(Value = "DK")]
    Dk,

    [EnumMember(Value = "P3")]
    P3
}
