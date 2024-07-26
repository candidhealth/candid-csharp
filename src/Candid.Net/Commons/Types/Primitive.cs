using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<Primitive>))]
public enum Primitive
{
    [EnumMember(Value = "BOOLEAN")]
    Boolean,

    [EnumMember(Value = "DOUBLE")]
    Double,

    [EnumMember(Value = "INTEGER")]
    Integer,

    [EnumMember(Value = "STRING")]
    String
}
