using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<CodingAttributionType>))]
public enum CodingAttributionType
{
    [EnumMember(Value = "CANDID")]
    Candid,

    [EnumMember(Value = "CUSTOMER")]
    Customer,

    [EnumMember(Value = "TCN")]
    Tcn,

    [EnumMember(Value = "PJF")]
    Pjf
}
