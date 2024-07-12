using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(StringEnumSerializer<CoverageStatus>))]
public enum CoverageStatus
{
    [EnumMember(Value = "ACTIVE")]
    Active,

    [EnumMember(Value = "CANCELLED")]
    Cancelled,

    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "ENTERED_IN_ERROR")]
    EnteredInError
}
