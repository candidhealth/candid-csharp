using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<PresentOnAdmissionIndicatorCode>))]
public enum PresentOnAdmissionIndicatorCode
{
    [EnumMember(Value = "Y")]
    Cy,

    [EnumMember(Value = "N")]
    Cn,

    [EnumMember(Value = "U")]
    Cu,

    [EnumMember(Value = "W")]
    Cw,

    [EnumMember(Value = "1")]
    C1,
}
