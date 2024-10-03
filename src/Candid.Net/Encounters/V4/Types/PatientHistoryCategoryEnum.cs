using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<PatientHistoryCategoryEnum>))]
public enum PatientHistoryCategoryEnum
{
    [EnumMember(Value = "present_illness")]
    PresentIllness,

    [EnumMember(Value = "medical")]
    Medical,

    [EnumMember(Value = "family")]
    Family,

    [EnumMember(Value = "social")]
    Social,
}
