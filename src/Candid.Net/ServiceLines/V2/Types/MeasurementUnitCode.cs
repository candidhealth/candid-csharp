using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

[JsonConverter(typeof(EnumSerializer<MeasurementUnitCode>))]
public enum MeasurementUnitCode
{
    [EnumMember(Value = "ML")]
    Milliliters,

    [EnumMember(Value = "UN")]
    Units,

    [EnumMember(Value = "GR")]
    Grams,

    [EnumMember(Value = "F2")]
    InternationalUnit,

    [EnumMember(Value = "ME")]
    Milligram,
}
