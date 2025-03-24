using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(EnumSerializer<ReportTransmissionCode>))]
public enum ReportTransmissionCode
{
    [EnumMember(Value = "BM")]
    Cbm,

    [EnumMember(Value = "FX")]
    Cfx,
}
