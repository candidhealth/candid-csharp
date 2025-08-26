using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(EnumSerializer<ReferralSource>))]
public enum ReferralSource
{
    [EnumMember(Value = "HOSPITAL")]
    Hospital,

    [EnumMember(Value = "REFERRING_MD")]
    ReferringMd,

    [EnumMember(Value = "SELF")]
    Self,

    [EnumMember(Value = "OTHER")]
    Other,
}
