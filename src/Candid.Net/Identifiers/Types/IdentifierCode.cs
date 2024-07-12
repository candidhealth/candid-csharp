using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<IdentifierCode>))]
public enum IdentifierCode
{
    [EnumMember(Value = "MCR")]
    Mcr,

    [EnumMember(Value = "MCD")]
    Mcd
}
