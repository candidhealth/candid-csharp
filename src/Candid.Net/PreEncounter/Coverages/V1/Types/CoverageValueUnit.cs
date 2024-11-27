using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

[JsonConverter(typeof(EnumSerializer<CoverageValueUnit>))]
public enum CoverageValueUnit
{
    [EnumMember(Value = "PERCENT")]
    Percent,

    [EnumMember(Value = "CURRENCY")]
    Currency,

    [EnumMember(Value = "COUNT")]
    Count,
}
