using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

[JsonConverter(typeof(StringEnumSerializer<ServiceIdQualifier>))]
public enum ServiceIdQualifier
{
    [EnumMember(Value = "EN")]
    EanUcc13,

    [EnumMember(Value = "EO")]
    EanUcc8,

    [EnumMember(Value = "HI")]
    Hibc,

    [EnumMember(Value = "N4")]
    Ndc542Format,

    [EnumMember(Value = "ON")]
    CustomerOrderNumber,

    [EnumMember(Value = "UK")]
    Gtin,

    [EnumMember(Value = "UP")]
    Ucc12
}
