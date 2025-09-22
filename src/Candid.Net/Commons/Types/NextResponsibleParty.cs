using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

[JsonConverter(typeof(EnumSerializer<NextResponsibleParty>))]
public enum NextResponsibleParty
{
    [EnumMember(Value = "primary")]
    Primary,

    [EnumMember(Value = "secondary")]
    Secondary,

    [EnumMember(Value = "tertiary")]
    Tertiary,

    [EnumMember(Value = "patient")]
    Patient,

    [EnumMember(Value = "non_insurance")]
    NonInsurance,

    [EnumMember(Value = "none")]
    None,
}
