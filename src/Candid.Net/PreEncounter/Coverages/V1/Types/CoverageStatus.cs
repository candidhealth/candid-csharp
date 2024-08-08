using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

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
